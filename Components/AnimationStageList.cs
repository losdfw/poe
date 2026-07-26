using System;
using System.Collections.Generic;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000377 RID: 887
	public class AnimationStageList : RemoteMemoryObject
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x001E6C78 File Offset: 0x001E6C78
		private NativePtrArray StageList
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x001E6C8C File Offset: 0x001E6C8C
		public List<AnimationStage> AllStages
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600184E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.Components.AnimationStage> ExileCore2.PoEMemory.Components.AnimationStageList::get_AllStages()

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
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x001E6CD4 File Offset: 0x001E6CD4
		public AnimationStageList()
		{
			this;
		}

		// Token: 0x04009674 RID: 38516
		private List<AnimationStage> _stages;
	}
}
