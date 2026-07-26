using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000372 RID: 882
	public class ActiveAnimationData : StructuredRemoteMemoryObject<ActiveAnimationOffsets>
	{
		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x001E68E8 File Offset: 0x001E68E8
		public int AnimationId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x001E68F8 File Offset: 0x001E68F8
		public float SlowAnimationSpeed
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x001E6908 File Offset: 0x001E6908
		public float NormalAnimationSpeed
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x001E6918 File Offset: 0x001E6918
		public float? AnimationSpeed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001839)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Single> ExileCore2.PoEMemory.Components.ActiveAnimationData::get_AnimationSpeed()

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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x001E6954 File Offset: 0x001E6954
		public AnimationStage SlowAnimationStartStage
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x001E6968 File Offset: 0x001E6968
		public AnimationStage SlowAnimationEndStage
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x001E697C File Offset: 0x001E697C
		public Func<float, float> TransformRawProgressFunc
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600183C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Func`2<System.Single,System.Single> ExileCore2.PoEMemory.Components.ActiveAnimationData::get_TransformRawProgressFunc()

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

		// Token: 0x0600183D RID: 6205 RVA: 0x001E6A34 File Offset: 0x001E6A34
		public ActiveAnimationData()
		{
			this;
		}
	}
}
