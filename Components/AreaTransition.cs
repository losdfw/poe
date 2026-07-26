using System;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2.Components;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000379 RID: 889
	public class AreaTransition : Component
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x001E6E70 File Offset: 0x001E6E70
		public AreaTransition()
		{
			this;
			this;
			this;
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x001E6E94 File Offset: 0x001E6E94
		public int WorldAreaId
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600185B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.AreaTransition::get_WorldAreaId()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x001E6EA8 File Offset: 0x001E6EA8
		public WorldArea AreaById
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x001E6EC4 File Offset: 0x001E6EC4
		public WorldArea WorldArea
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x001E6EEC File Offset: 0x001E6EEC
		public AreaTransitionType TransitionType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04009677 RID: 38519
		private readonly CachedValue<t31466> _cache;
	}
}
