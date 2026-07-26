using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;
using Serilog.Events;

namespace ExileCore2
{
	// Token: 0x0200003D RID: 61
	[Submenu]
	public class CorePluginSettings
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0019C52C File Offset: 0x0019C52C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0019C534 File Offset: 0x0019C534
		[Menu("Load source plugins in parallel", "Requires restart to apply. When you use a lot of plugins this option can improve the load time.")]
		public ToggleNode MultiThreadLoadPlugins
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0019C540 File Offset: 0x0019C540
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0019C548 File Offset: 0x0019C548
		[Menu("Avoid locking plugin dlls", "Requires restart to apply. Only enable this if you need to do live dll replacement without restarting.")]
		public ToggleNode AvoidLockingDllFiles
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0019C554 File Offset: 0x0019C554
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0019C55C File Offset: 0x0019C55C
		[Menu(null, "Requires restart to apply. Load plugins from source even if there is a compiled plugin with the same name")]
		public ToggleNode PreferSourcePlugins
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0019C568 File Offset: 0x0019C568
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0019C570 File Offset: 0x0019C570
		[Menu(null, "Start one build using a graph with all plugins included. Decreases total build time")]
		[JsonProperty("BuildAllPluginsAtOnce_v2")]
		public ToggleNode BuildAllPluginsAtOnce
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0019C57C File Offset: 0x0019C57C
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0019C584 File Offset: 0x0019C584
		public ToggleNode CachePluginCompilationResults
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0019C590 File Offset: 0x0019C590
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0019C598 File Offset: 0x0019C598
		[Menu(null, "You probably don't want to enable this")]
		public ToggleNode IgnoreReferenceChangesForCompilationCache
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0019C5A4 File Offset: 0x0019C5A4
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0019C5AC File Offset: 0x0019C5AC
		[JsonIgnore]
		public ButtonNode ResetCompilationCache
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0019C5B8 File Offset: 0x0019C5B8
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0019C5C0 File Offset: 0x0019C5C0
		public CorePluginSettings.PluginFolderSettings FolderSettings
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0019C5CC File Offset: 0x0019C5CC
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0019C5D4 File Offset: 0x0019C5D4
		public CorePluginSettings.PluginNotificationSettings NotificationSettings
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0019C5E0 File Offset: 0x0019C5E0
		public CorePluginSettings()
		{
			this;
			0;
			this;
			0;
			this;
			0;
			this;
			1;
			this;
			1;
			this;
			0;
			this;
			this;
			this;
			this;
		}

		// Token: 0x0200003E RID: 62
		[Submenu(RenderMethod = "Render", CollapsedByDefault = true, EnableSelfDrawCollapsing = true)]
		public class PluginFolderSettings
		{
			// Token: 0x060001EE RID: 494 RVA: 0x0019C660 File Offset: 0x0019C660
			public void Render()
			{
				/*
An exception occurred when decompiling this method (060001EE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginFolderSettings::Render()

 ---> System.ArgumentOutOfRangeException: length ('-1') must be a non-negative value. (Parameter 'length')
Actual value was -1.
   at System.ArgumentOutOfRangeException.ThrowNegative[T](T value, String paramName)
   at System.Array.CopyImpl(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 289
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x0019C918 File Offset: 0x0019C918
			public PluginFolderSettings()
			{
				this;
				this;
				this;
			}

			// Token: 0x040000E5 RID: 229
			public List<CorePluginSettings.PluginFolderSettings.PluginFolder> PluginFolders;

			// Token: 0x040000E6 RID: 230
			public Dictionary<string, Guid?> PluginFolderMapping;

			// Token: 0x0200003F RID: 63
			public class PluginFolder
			{
				// Token: 0x17000075 RID: 117
				// (get) Token: 0x060001F0 RID: 496 RVA: 0x0019C938 File Offset: 0x0019C938
				// (set) Token: 0x060001F1 RID: 497 RVA: 0x0019C940 File Offset: 0x0019C940
				public Guid Id
				{
					[CompilerGenerated]
					get
					{
						return this;
					}
					[CompilerGenerated]
					set
					{
						this;
						value;
					}
				}

				// Token: 0x060001F2 RID: 498 RVA: 0x0019C94C File Offset: 0x0019C94C
				public PluginFolder()
				{
					this;
					this;
				}

				// Token: 0x040000E8 RID: 232
				public string Name;

				// Token: 0x040000E9 RID: 233
				public Vector4 Color;

				// Token: 0x040000EA RID: 234
				public bool CollapsedByDefault;
			}
		}

		// Token: 0x02000041 RID: 65
		[Submenu(CollapsedByDefault = true)]
		public class PluginNotificationSettings
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x0019C984 File Offset: 0x0019C984
			// (set) Token: 0x060001F7 RID: 503 RVA: 0x0019C98C File Offset: 0x0019C98C
			public ToggleNode Show
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x0019C998 File Offset: 0x0019C998
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x0019C9A0 File Offset: 0x0019C9A0
			public ToggleNode ShowWhenNoNotifications
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001FA RID: 506 RVA: 0x0019C9AC File Offset: 0x0019C9AC
			// (set) Token: 0x060001FB RID: 507 RVA: 0x0019C9B4 File Offset: 0x0019C9B4
			public ToggleNode MoveWhenSettingsOpen
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001FC RID: 508 RVA: 0x0019C9C0 File Offset: 0x0019C9C0
			// (set) Token: 0x060001FD RID: 509 RVA: 0x0019C9C8 File Offset: 0x0019C9C8
			public ListNode MinMapEventLevel
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001FE RID: 510 RVA: 0x0019C9D4 File Offset: 0x0019C9D4
			// (set) Token: 0x060001FF RID: 511 RVA: 0x0019C9DC File Offset: 0x0019C9DC
			public ListNode MinEventLevel
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000200 RID: 512 RVA: 0x0019C9E8 File Offset: 0x0019C9E8
			// (set) Token: 0x06000201 RID: 513 RVA: 0x0019C9F0 File Offset: 0x0019C9F0
			public ColorNode VerboseNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000202 RID: 514 RVA: 0x0019C9FC File Offset: 0x0019C9FC
			// (set) Token: 0x06000203 RID: 515 RVA: 0x0019CA04 File Offset: 0x0019CA04
			public ColorNode DebugNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000204 RID: 516 RVA: 0x0019CA10 File Offset: 0x0019CA10
			// (set) Token: 0x06000205 RID: 517 RVA: 0x0019CA18 File Offset: 0x0019CA18
			public ColorNode InfoNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000206 RID: 518 RVA: 0x0019CA24 File Offset: 0x0019CA24
			// (set) Token: 0x06000207 RID: 519 RVA: 0x0019CA2C File Offset: 0x0019CA2C
			public ColorNode WarningNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000208 RID: 520 RVA: 0x0019CA38 File Offset: 0x0019CA38
			// (set) Token: 0x06000209 RID: 521 RVA: 0x0019CA40 File Offset: 0x0019CA40
			public ColorNode ErrorNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600020A RID: 522 RVA: 0x0019CA4C File Offset: 0x0019CA4C
			// (set) Token: 0x0600020B RID: 523 RVA: 0x0019CA54 File Offset: 0x0019CA54
			public ColorNode FatalNotificationColor
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x0600020C RID: 524 RVA: 0x0019CA60 File Offset: 0x0019CA60
			// (set) Token: 0x0600020D RID: 525 RVA: 0x0019CA68 File Offset: 0x0019CA68
			public CorePluginSettings.PluginNotificationSettings.Categories CategoriesSettings
			{
				[CompilerGenerated]
				get
				{
					return this;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0019CA74 File Offset: 0x0019CA74
			public PluginNotificationSettings()
			{
				/*
An exception occurred when decompiling this method (0600020E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginNotificationSettings::.ctor()

 ---> System.Exception: Unknown OpCode: Stloc_0
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 1115
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x02000042 RID: 66
			[Submenu(RenderMethod = "Render", CollapsedByDefault = true, EnableSelfDrawCollapsing = true)]
			public class Categories
			{
				// Token: 0x0600020F RID: 527 RVA: 0x0019CBC4 File Offset: 0x0019CBC4
				public void Render()
				{
					/*
An exception occurred when decompiling this method (0600020F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginNotificationSettings/Categories::Render()

 ---> System.Exception: Inconsistent stack size at IL_0015
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
				}

				// Token: 0x06000210 RID: 528 RVA: 0x0019CE9C File Offset: 0x0019CE9C
				public Categories()
				{
					this;
					this;
					"";
					this;
				}

				// Token: 0x06000211 RID: 529 RVA: 0x0019CEBC File Offset: 0x0019CEBC
				// Note: this type is marked as 'beforefieldinit'.
				static Categories()
				{
					Enum.GetValues<LogEventLevel>();
				}

				// Token: 0x040000F9 RID: 249
				private static readonly List<string> LogEventLevelValues;

				// Token: 0x040000FA RID: 250
				public Dictionary<string, CorePluginSettings.PluginNotificationSettings.Categories.PerPluginSettings> Plugins;

				// Token: 0x040000FB RID: 251
				private string _filter;

				// Token: 0x02000043 RID: 67
				public class PerPluginSettings
				{
					// Token: 0x06000213 RID: 531 RVA: 0x0019CF08 File Offset: 0x0019CF08
					public PerPluginSettings()
					{
						this;
						"";
						this;
						"";
						this;
						"";
						this;
						"";
						this;
						this;
					}

					// Token: 0x040000FC RID: 252
					public string CategoryBlacklistRegex;

					// Token: 0x040000FD RID: 253
					public string MapCategoryBlacklistRegex;

					// Token: 0x040000FE RID: 254
					public string IdBlacklistRegex;

					// Token: 0x040000FF RID: 255
					public string MapIdBlacklistRegex;

					// Token: 0x04000100 RID: 256
					public List<CorePluginSettings.PluginNotificationSettings.Categories.PerPluginSettings.LevelMapping> LevelMappings;

					// Token: 0x02000044 RID: 68
					public class LevelMapping
					{
						// Token: 0x06000214 RID: 532 RVA: 0x0019CF48 File Offset: 0x0019CF48
						public LevelMapping()
						{
							this;
							"";
							this;
							"";
							this;
							2;
							this;
							"";
							this;
						}

						// Token: 0x04000101 RID: 257
						public string CategoryRegex;

						// Token: 0x04000102 RID: 258
						public string IdRegex;

						// Token: 0x04000103 RID: 259
						public LogEventLevel Level;

						// Token: 0x04000104 RID: 260
						internal string LevelInput;
					}
				}
			}
		}
	}
}
