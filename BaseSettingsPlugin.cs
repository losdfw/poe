using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared;
using ExileCore2.Shared.AtlasHelper;
using ExileCore2.Shared.Interfaces;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x02000030 RID: 48
	public abstract class BaseSettingsPlugin<TSettings> : IPlugin, IDisposable where TSettings : ISettings, new()
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00199624 File Offset: 0x00199624
		protected BaseSettingsPlugin()
		{
			this.InternalName = base.GetType().Namespace;
			this.Name = this.InternalName;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00199658 File Offset: 0x00199658
		public List<ISettingsHolder> Drawers { get; } = new List<ISettingsHolder>();

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00199660 File Offset: 0x00199660
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00199668 File Offset: 0x00199668
		public GameController GameController { get; private set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00199674 File Offset: 0x00199674
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0019967C File Offset: 0x0019967C
		public Graphics Graphics { get; private set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00199688 File Offset: 0x00199688
		public TSettings Settings
		{
			get
			{
				return (TSettings)((object)this._Settings);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00199698 File Offset: 0x00199698
		// (set) Token: 0x06000153 RID: 339 RVA: 0x001996A0 File Offset: 0x001996A0
		public ISettings _Settings { get; private set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000154 RID: 340 RVA: 0x001996AC File Offset: 0x001996AC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x001996B4 File Offset: 0x001996B4
		public bool CanUseMultiThreading { get; protected set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000156 RID: 342 RVA: 0x001996C0 File Offset: 0x001996C0
		// (set) Token: 0x06000157 RID: 343 RVA: 0x001996C8 File Offset: 0x001996C8
		public string Description { get; protected set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000158 RID: 344 RVA: 0x001996D4 File Offset: 0x001996D4
		// (set) Token: 0x06000159 RID: 345 RVA: 0x001996DC File Offset: 0x001996DC
		public string DirectoryName { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600015A RID: 346 RVA: 0x001996E8 File Offset: 0x001996E8
		// (set) Token: 0x0600015B RID: 347 RVA: 0x001996F0 File Offset: 0x001996F0
		public string DirectoryFullName { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600015C RID: 348 RVA: 0x001996FC File Offset: 0x001996FC
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00199704 File Offset: 0x00199704
		public bool Force { get; protected set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00199710 File Offset: 0x00199710
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00199718 File Offset: 0x00199718
		public bool Initialized { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00199724 File Offset: 0x00199724
		public string InternalName { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0019972C File Offset: 0x0019972C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00199734 File Offset: 0x00199734
		public string Name { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00199740 File Offset: 0x00199740
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00199748 File Offset: 0x00199748
		public int Order { get; protected set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00199754 File Offset: 0x00199754
		public string ConfigDirectory
		{
			get
			{
				return this.GameController.Settings.GetPluginSettingsDirectory(this);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00199768 File Offset: 0x00199768
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00199770 File Offset: 0x00199770
		public PluginManager PluginManager { get; private set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0019977C File Offset: 0x0019977C
		public CancellationToken ZoneCancellationToken
		{
			get
			{
				return this.PluginManager.ZoneCancellationToken;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0019978C File Offset: 0x0019978C
		public void _LoadSettings()
		{
			try
			{
				string text = this.GameController.Settings.LoadSettings(this);
				bool flag = text != null;
				if (flag)
				{
					this._Settings = JsonConvert.DeserializeObject<TSettings>(text, SettingsContainer.jsonSettings);
				}
			}
			catch (Exception ex)
			{
				DebugWindow.LogError(ex.ToString());
			}
			if (this._Settings == null)
			{
				this._Settings = new TSettings();
			}
			SettingsParser.Parse(this._Settings, this.Drawers, -1);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00199820 File Offset: 0x00199820
		public void _SaveSettings()
		{
			bool flag = this._Settings == null;
			if (flag)
			{
				throw new NullReferenceException("Plugin settings is null");
			}
			this.GameController.Settings.SaveSettings(this);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00199858 File Offset: 0x00199858
		public virtual void AreaChange(AreaInstance area)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0019985C File Offset: 0x0019985C
		public virtual void Dispose()
		{
			this.OnClose();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00199868 File Offset: 0x00199868
		public virtual void DrawSettings()
		{
			foreach (ISettingsHolder settingsHolder in this.Drawers)
			{
				settingsHolder.Draw();
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x001998C0 File Offset: 0x001998C0
		public virtual void EntityAdded(Entity entity)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x001998C4 File Offset: 0x001998C4
		public virtual void EntityAddedAny(Entity entity)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x001998C8 File Offset: 0x001998C8
		public virtual void EntityIgnored(Entity entity)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x001998CC File Offset: 0x001998CC
		public virtual void EntityRemoved(Entity entity)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x001998D0 File Offset: 0x001998D0
		public virtual void OnLoad()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x001998D4 File Offset: 0x001998D4
		public virtual void OnUnload()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x001998D8 File Offset: 0x001998D8
		public virtual bool Initialise()
		{
			return true;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x001998EC File Offset: 0x001998EC
		public void LogMsg(string msg)
		{
			DebugWindow.LogMsg(msg);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x001998F8 File Offset: 0x001998F8
		public virtual void OnClose()
		{
			this._SaveSettings();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00199904 File Offset: 0x00199904
		public virtual void ReceiveEvent(string eventId, object args)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00199908 File Offset: 0x00199908
		public void PublishEvent(string eventId, object args)
		{
			this.PluginManager.ReceivePluginEvent(eventId, args, this);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0019991C File Offset: 0x0019991C
		public virtual void OnPluginSelectedInMenu()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00199920 File Offset: 0x00199920
		public virtual void Tick()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00199924 File Offset: 0x00199924
		public virtual void Render()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00199928 File Offset: 0x00199928
		public void LogError(string msg)
		{
			DebugWindow.LogError("[" + this.Name + "] " + msg);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00199948 File Offset: 0x00199948
		public void LogError(string msg, float time)
		{
			DebugWindow.LogError("[" + this.Name + "] " + msg, time);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00199968 File Offset: 0x00199968
		public void LogMessage(string msg, float time, Color clr)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg, time, clr);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0019998C File Offset: 0x0019998C
		public void LogMessage(string msg)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x001999AC File Offset: 0x001999AC
		public void LogMessage(string msg, float time)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg, time);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x001999CC File Offset: 0x001999CC
		public virtual void OnPluginDestroyForHotReload()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x001999D0 File Offset: 0x001999D0
		public void SetApi(GameController gameController, Graphics graphics, PluginManager pluginManager)
		{
			this.GameController = gameController;
			this.Graphics = graphics;
			this.PluginManager = pluginManager;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x001999EC File Offset: 0x001999EC
		public void PostNotification(PluginNotification notification)
		{
			this.PluginManager.Notifications[new PluginManager.NotificationId(this.InternalName, notification.Category, notification.Id)] = notification;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00199A18 File Offset: 0x00199A18
		public void RemoveAllNotifications()
		{
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in this.PluginManager.Notifications.Where<KeyValuePair<PluginManager.NotificationId, PluginNotification>>((KeyValuePair<PluginManager.NotificationId, PluginNotification> x) => x.Key.PluginId == this.InternalName).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00199AA0 File Offset: 0x00199AA0
		public void RemoveNotifications(string category)
		{
			IEnumerable<KeyValuePair<PluginManager.NotificationId, PluginNotification>> notifications = this.PluginManager.Notifications;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> <>9__0;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> func;
			if ((func = <>9__0) == null)
			{
				func = (<>9__0 = (KeyValuePair<PluginManager.NotificationId, PluginNotification> x) => x.Key.PluginId == this.InternalName && x.Key.Category == category);
			}
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in notifications.Where<KeyValuePair<PluginManager.NotificationId, PluginNotification>>(func).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00199B50 File Offset: 0x00199B50
		public void RemoveNotification(string category, string id)
		{
			IEnumerable<KeyValuePair<PluginManager.NotificationId, PluginNotification>> notifications = this.PluginManager.Notifications;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> <>9__0;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> func;
			if ((func = <>9__0) == null)
			{
				func = (<>9__0 = (KeyValuePair<PluginManager.NotificationId, PluginNotification> x) => x.Key.PluginId == this.InternalName && x.Key.Category == category && x.Key.Notification == id);
			}
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in notifications.Where<KeyValuePair<PluginManager.NotificationId, PluginNotification>>(func).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00199C04 File Offset: 0x00199C04
		public AtlasTexture GetAtlasTexture(string textureName)
		{
			bool flag = this._atlasTextures == null;
			if (flag)
			{
				string text = Path.Combine(this.DirectoryFullName, "textures");
				string[] files = Directory.GetFiles(text, "*.json");
				bool flag2 = files.Length == 0;
				if (flag2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas json config file in '");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear() + "(expecting config 'from Free texture packer' program)", 20f);
					this._atlasTextures = new AtlasTexturesProcessor("%AtlasNotFound%");
					return null;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[0]);
				bool flag3 = files.Length > 1;
				if (flag3)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Found multiple atlas configs in folder '");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("', ");
					defaultInterpolatedStringHandler.AppendLiteral("selecting the first one ''");
					defaultInterpolatedStringHandler.AppendFormatted(fileNameWithoutExtension);
					defaultInterpolatedStringHandler.AppendLiteral("''");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
				}
				string text2 = Path.Combine(this.DirectoryFullName, "textures\\" + fileNameWithoutExtension + ".png");
				bool flag4 = !File.Exists(text2);
				if (flag4)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas png texture file in '");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
					this._atlasTextures = new AtlasTexturesProcessor(fileNameWithoutExtension);
					return null;
				}
				this._atlasTextures = new AtlasTexturesProcessor(files[0], text2);
				this.Graphics.InitImage(text2, false);
			}
			return this._atlasTextures.GetTextureByName(textureName);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00199E34 File Offset: 0x00199E34
		public AtlasTexturesProcessor CreateAtlas(string configPath, string texturePath)
		{
			bool flag = !File.Exists(configPath);
			AtlasTexturesProcessor atlasTexturesProcessor;
			if (flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
				defaultInterpolatedStringHandler.AppendFormatted(this.Name);
				defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas json config file in '");
				defaultInterpolatedStringHandler.AppendFormatted(configPath);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
				atlasTexturesProcessor = new AtlasTexturesProcessor("%AtlasNotFound%");
			}
			else
			{
				bool flag2 = !File.Exists(texturePath);
				if (flag2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas png texture file in '");
					defaultInterpolatedStringHandler.AppendFormatted(texturePath);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
					atlasTexturesProcessor = new AtlasTexturesProcessor("%AtlasNotFound%");
				}
				else
				{
					this.Graphics.InitImage(texturePath, false);
					atlasTexturesProcessor = new AtlasTexturesProcessor(configPath, texturePath);
				}
			}
			return atlasTexturesProcessor;
		}

		// Token: 0x0400007F RID: 127
		private AtlasTexturesProcessor _atlasTextures;
	}
}
