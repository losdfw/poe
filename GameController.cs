using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using ExileCore2.PoEMemory;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2
{
	// Token: 0x02000066 RID: 102
	public class GameController : IDisposable
	{
		// Token: 0x06000356 RID: 854 RVA: 0x001A0B4C File Offset: 0x001A0B4C
		public GameController(Memory memory, SoundController soundController, SettingsContainer settings)
		{
			/*
An exception occurred when decompiling this method (06000356)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::.ctor(ExileCore2.Memory,ExileCore2.SoundController,ExileCore2.SettingsContainer)

 ---> System.Exception: Inconsistent stack size at IL_0025
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000357 RID: 855 RVA: 0x001A0E08 File Offset: 0x001A0E08
		public CancellationToken ControllerCancellation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000358 RID: 856 RVA: 0x001A0E18 File Offset: 0x001A0E18
		public TimeSpan ActivePeriod
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000359 RID: 857 RVA: 0x001A0E28 File Offset: 0x001A0E28
		public TheGame Game
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600035A RID: 858 RVA: 0x001A0E30 File Offset: 0x001A0E30
		public AreaController Area
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600035B RID: 859 RVA: 0x001A0E38 File Offset: 0x001A0E38
		public GameWindow Window
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600035C RID: 860 RVA: 0x001A0E40 File Offset: 0x001A0E40
		public IngameState IngameState
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600035D RID: 861 RVA: 0x001A0E50 File Offset: 0x001A0E50
		public FilesContainer Files
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600035E RID: 862 RVA: 0x001A0E60 File Offset: 0x001A0E60
		public Entity Player
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600035F RID: 863 RVA: 0x001A0E70 File Offset: 0x001A0E70
		// (set) Token: 0x06000360 RID: 864 RVA: 0x001A0E78 File Offset: 0x001A0E78
		public bool IsForeGroundCache
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000361 RID: 865 RVA: 0x001A0E84 File Offset: 0x001A0E84
		// (set) Token: 0x06000362 RID: 866 RVA: 0x001A0E8C File Offset: 0x001A0E8C
		public bool InGame
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000363 RID: 867 RVA: 0x001A0E98 File Offset: 0x001A0E98
		// (set) Token: 0x06000364 RID: 868 RVA: 0x001A0EA0 File Offset: 0x001A0EA0
		public bool IsLoading
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000365 RID: 869 RVA: 0x001A0EAC File Offset: 0x001A0EAC
		public PluginPanel LeftPanel
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000366 RID: 870 RVA: 0x001A0EB4 File Offset: 0x001A0EB4
		public PluginPanel UnderPanel
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000367 RID: 871 RVA: 0x001A0EBC File Offset: 0x001A0EBC
		public IMemory Memory
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000368 RID: 872 RVA: 0x001A0EC4 File Offset: 0x001A0EC4
		public SoundController SoundController
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000369 RID: 873 RVA: 0x001A0ECC File Offset: 0x001A0ECC
		public SettingsContainer Settings
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600036A RID: 874 RVA: 0x001A0ED4 File Offset: 0x001A0ED4
		public EntityListWrapper EntityListWrapper
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600036B RID: 875 RVA: 0x001A0EDC File Offset: 0x001A0EDC
		// (set) Token: 0x0600036C RID: 876 RVA: 0x001A0EE4 File Offset: 0x001A0EE4
		public Cache Cache
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600036D RID: 877 RVA: 0x001A0EF0 File Offset: 0x001A0EF0
		public double DeltaTime
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600036E RID: 878 RVA: 0x001A0F00 File Offset: 0x001A0F00
		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600036F RID: 879 RVA: 0x001A0F08 File Offset: 0x001A0F08
		public ICollection<Entity> Entities
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000370 RID: 880 RVA: 0x001A0F18 File Offset: 0x001A0F18
		public Dictionary<string, object> Debug
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000371 RID: 881 RVA: 0x001A0F20 File Offset: 0x001A0F20
		public bool IsUsingController
		{
			get
			{
				return this == 2;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000372 RID: 882 RVA: 0x001A0F30 File Offset: 0x001A0F30
		public bool IsWaitingForDelayedAreaChange
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x001A0F40 File Offset: 0x001A0F40
		public void Dispose()
		{
			/*
An exception occurred when decompiling this method (06000373)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::Dispose()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000374 RID: 884 RVA: 0x001A0FE0 File Offset: 0x001A0FE0
		// (remove) Token: 0x06000375 RID: 885 RVA: 0x001A1014 File Offset: 0x001A1014
		public static event Action<bool> eIsForegroundChanged
		{
			[CompilerGenerated]
			add
			{
				/*
An exception occurred when decompiling this method (06000374)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::add_eIsForegroundChanged(System.Action`1<System.Boolean>)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
			[CompilerGenerated]
			remove
			{
				/*
An exception occurred when decompiling this method (06000375)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::remove_eIsForegroundChanged(System.Action`1<System.Boolean>)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x001A1048 File Offset: 0x001A1048
		public void Tick()
		{
			/*
An exception occurred when decompiling this method (06000376)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::Tick()

 ---> System.Exception: Inconsistent stack size at IL_0038
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x001A1224 File Offset: 0x001A1224
		internal void RunBeforeFrameTasks()
		{
			/*
An exception occurred when decompiling this method (06000377)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::RunBeforeFrameTasks()

 ---> System.Exception: Inconsistent stack size at IL_0004
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x001A1508 File Offset: 0x001A1508
		private Vector2 GetLeftCornerMap()
		{
			/*
An exception occurred when decompiling this method (06000378)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector2 ExileCore2.GameController::GetLeftCornerMap()

 ---> System.Exception: Inconsistent stack size at IL_0009
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x001A1618 File Offset: 0x001A1618
		private Vector2 GetUnderCornerMap()
		{
			/*
An exception occurred when decompiling this method (06000379)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector2 ExileCore2.GameController::GetUnderCornerMap()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x001A1630 File Offset: 0x001A1630
		public void RegisterInspector(Action<object, string, bool> inspectAction)
		{
			this;
			inspectAction;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x001A163C File Offset: 0x001A163C
		public void InspectObject(object obj, string name, bool makeWindow = true)
		{
			GameController gameController = this;
			while ((gameController = gameController) != null)
			{
			}
			throw "No inspector registered";
		}

		// Token: 0x0600037C RID: 892 RVA: 0x001A1660 File Offset: 0x001A1660
		// Note: this type is marked as 'beforefieldinit'.
		static GameController()
		{
			GameController.<>c.<>9;
		}

		// Token: 0x040001AA RID: 426
		private readonly CoreSettings _settings;

		// Token: 0x040001AB RID: 427
		private readonly DebugInformation debDeltaTime;

		// Token: 0x040001AC RID: 428
		private readonly TimeCache<Vector2> _leftCornerMap;

		// Token: 0x040001AD RID: 429
		private readonly TimeCache<Vector2> _underCornerMap;

		// Token: 0x040001AE RID: 430
		private bool IsForeGroundLast;

		// Token: 0x040001AF RID: 431
		private bool _everWasInGame;

		// Token: 0x040001B0 RID: 432
		private bool _wasPreGame;

		// Token: 0x040001B1 RID: 433
		public readonly PluginBridge PluginBridge;

		// Token: 0x040001B2 RID: 434
		private readonly List<IDisposable> _attachments;

		// Token: 0x040001B3 RID: 435
		private Action<object, string, bool> _debugInspector;

		// Token: 0x040001B4 RID: 436
		private readonly Stopwatch _sinceCreation;

		// Token: 0x040001B5 RID: 437
		private readonly CancellationTokenSource _controllerCancellationTokenSource;

		// Token: 0x040001C6 RID: 454
		internal readonly ConcurrentDictionary<string, Action> BeforeFrameActions;

		// Token: 0x040001C7 RID: 455
		internal readonly ConcurrentDictionary<string, Func<SyncTask<bool>>> BeforeFrameSyncTasks;

		// Token: 0x040001C8 RID: 456
		private readonly ConcurrentDictionary<string, SyncTask<bool>> _activeBeforeFrameSyncTasks;
	}
}
