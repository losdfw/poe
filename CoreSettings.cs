using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x02000048 RID: 72
	public class CoreSettings : ISettings
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0019D110 File Offset: 0x0019D110
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0019D118 File Offset: 0x0019D118
		[Menu("Refresh area")]
		[JsonIgnore]
		public ButtonNode RefreshArea
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0019D124 File Offset: 0x0019D124
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0019D12C File Offset: 0x0019D12C
		[JsonIgnore]
		public ButtonNode ReloadFiles
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0019D138 File Offset: 0x0019D138
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0019D140 File Offset: 0x0019D140
		[JsonIgnore]
		public ButtonNode ClearEntityCache
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0019D14C File Offset: 0x0019D14C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0019D154 File Offset: 0x0019D154
		[Menu(null, "Uses more memory, should be faster")]
		public ToggleNode UseNewMemoryBackend
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0019D160 File Offset: 0x0019D160
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0019D168 File Offset: 0x0019D168
		[Menu("List profiles", "Currently not works. Soon.")]
		public ListNode Profiles
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0019D174 File Offset: 0x0019D174
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0019D17C File Offset: 0x0019D17C
		[Menu("Current Menu Theme")]
		public ListNode Theme
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0019D188 File Offset: 0x0019D188
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0019D190 File Offset: 0x0019D190
		public HotkeyNodeV2 MainMenuKeyToggle
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0019D19C File Offset: 0x0019D19C
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0019D1A4 File Offset: 0x0019D1A4
		public HotkeyNodeV2 PauseAllPluginsHotkey
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0019D1B0 File Offset: 0x0019D1B0
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0019D1B8 File Offset: 0x0019D1B8
		public CorePluginSettings PluginSettings
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0019D1C4 File Offset: 0x0019D1C4
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0019D1CC File Offset: 0x0019D1CC
		public CorePerformanceSettings PerformanceSettings
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0019D1D8 File Offset: 0x0019D1D8
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0019D1E0 File Offset: 0x0019D1E0
		public ToggleNode AttachToMainProcessWindow
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0019D1EC File Offset: 0x0019D1EC
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0019D1F4 File Offset: 0x0019D1F4
		public ToggleNode TryLoadingStatDescriptionsFromGameData
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0019D200 File Offset: 0x0019D200
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0019D208 File Offset: 0x0019D208
		public ToggleNode RepairInvalidGameAddress
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0019D214 File Offset: 0x0019D214
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0019D21C File Offset: 0x0019D21C
		public RangeNode<float> AreaRefreshDelay
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0019D228 File Offset: 0x0019D228
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0019D230 File Offset: 0x0019D230
		public ToggleNode CacheEntitiesBetweenZones
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0019D23C File Offset: 0x0019D23C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0019D244 File Offset: 0x0019D244
		public RangeNode<float> GlobalEntityCacheExpirationMinutes
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0019D250 File Offset: 0x0019D250
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0019D258 File Offset: 0x0019D258
		public ToggleNode UseOldStyleListNode
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0019D264 File Offset: 0x0019D264
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0019D26C File Offset: 0x0019D26C
		public ToggleNode IgnoreHotkeysOnFocusedInput
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0019D278 File Offset: 0x0019D278
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0019D280 File Offset: 0x0019D280
		public ToggleNode UseSubInventoryItems
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0019D28C File Offset: 0x0019D28C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0019D294 File Offset: 0x0019D294
		[Menu("Enable VSync")]
		public ToggleNode EnableVSync
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0019D2A0 File Offset: 0x0019D2A0
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0019D2A8 File Offset: 0x0019D2A8
		public CoreFontSettings FontSettings
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0019D2B4 File Offset: 0x0019D2B4
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0019D2BC File Offset: 0x0019D2BC
		[Menu(null, "If you use a large custom cursor, this can help see tooltips better")]
		public RangeNode<float> MouseCursorScale
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0019D2C8 File Offset: 0x0019D2C8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0019D2D0 File Offset: 0x0019D2D0
		public RangeNode<int> Volume
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0019D2DC File Offset: 0x0019D2DC
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0019D2E4 File Offset: 0x0019D2E4
		public ToggleNode ShowDebugWindow
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0019D2F0 File Offset: 0x0019D2F0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0019D2F8 File Offset: 0x0019D2F8
		public ToggleNode ShowLogWindow
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0019D304 File Offset: 0x0019D304
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0019D30C File Offset: 0x0019D30C
		public CoreLoggingSettings LoggingSettings
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0019D318 File Offset: 0x0019D318
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0019D320 File Offset: 0x0019D320
		public CoreDebugSettings DebugSettings
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0019D32C File Offset: 0x0019D32C
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0019D334 File Offset: 0x0019D334
		public ToggleNode Enable
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0019D340 File Offset: 0x0019D340
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0019D348 File Offset: 0x0019D348
		public ToggleNode ForceForeground
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0019D354 File Offset: 0x0019D354
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0019D35C File Offset: 0x0019D35C
		[Menu(null, "Set to 0 to disable")]
		public RangeNode<int> FileReloadPeriod
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0019D368 File Offset: 0x0019D368
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0019D370 File Offset: 0x0019D370
		[Menu(null, "If you have a widescreen display and use some sort of a hack to force poe to render without black bars, you might need this")]
		public ToggleNode DisableBlackBarAdjustment
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0019D37C File Offset: 0x0019D37C
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0019D384 File Offset: 0x0019D384
		[JsonIgnore]
		public ButtonNode ReloadPlugins
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0019D390 File Offset: 0x0019D390
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0019D398 File Offset: 0x0019D398
		[JsonIgnore]
		[ConditionalDisplay("IsRunningAsAdmin", false)]
		public ButtonNode RestartAsAdmin
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0019D3A4 File Offset: 0x0019D3A4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0019D3AC File Offset: 0x0019D3AC
		public SnapshotSettings SnapshotSettings
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

		// Token: 0x06000270 RID: 624 RVA: 0x0019D3B8 File Offset: 0x0019D3B8
		public bool IsRunningAsAdmin()
		{
			/*
An exception occurred when decompiling this method (06000270)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.CoreSettings::IsRunningAsAdmin()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0019D3D0 File Offset: 0x0019D3D0
		public CoreSettings()
		{
			/*
An exception occurred when decompiling this method (06000271)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CoreSettings::.ctor()

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

		// Token: 0x04000133 RID: 307
		public int IconPickerIconsPerRow;

		// Token: 0x04000134 RID: 308
		public int IconPickerIconSize;
	}
}
