using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003B5 RID: 949
	public class Pathfinding : Component
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x001E9FE8 File Offset: 0x001E9FE8
		public Pathfinding()
		{
			this;
			this;
			this;
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x001EA00C File Offset: 0x001EA00C
		private PathfindingComponentOffsets Offsets
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x001EA01C File Offset: 0x001EA01C
		public Vector2i TargetMovePos
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GameOffsets2.Native.Vector2i ExileCore2.PoEMemory.Components.Pathfinding::get_TargetMovePos()

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

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x001EA034 File Offset: 0x001EA034
		public Vector2i PreviousMovePos
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GameOffsets2.Native.Vector2i ExileCore2.PoEMemory.Components.Pathfinding::get_PreviousMovePos()

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

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x001EA04C File Offset: 0x001EA04C
		public Vector2i WantMoveToPosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x001EA05C File Offset: 0x001EA05C
		public bool IsMoving
		{
			get
			{
				return this > 0;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x001EA06C File Offset: 0x001EA06C
		public int DestinationNodes
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x001EA07C File Offset: 0x001EA07C
		public float StayTime
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x001EA08C File Offset: 0x001EA08C
		public IList<Vector2i> PathingNodes
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<GameOffsets2.Native.Vector2i> ExileCore2.PoEMemory.Components.Pathfinding::get_PathingNodes()

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x040096BA RID: 38586
		private readonly CachedValue<PathfindingComponentOffsets> _cachedValue;
	}
}
