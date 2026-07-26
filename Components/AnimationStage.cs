using System;
using System.Numerics;
using ExileCore2.PoEMemory.FilesInMemory.Animations;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000378 RID: 888
	public class AnimationStage : RemoteMemoryObject
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x001E6D0C File Offset: 0x001E6D0C
		public AnimationStage()
		{
			this;
			this;
			this;
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x001E6D30 File Offset: 0x001E6D30
		public string StageName
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001852)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.AnimationStage::get_StageName()

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

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x001E6D6C File Offset: 0x001E6D6C
		public float StageStart
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x001E6D80 File Offset: 0x001E6D80
		public AnimationEventType EventType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x001E6D94 File Offset: 0x001E6D94
		public Vector3 Position
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x001E6DA8 File Offset: 0x001E6DA8
		public Vector3 ContactRef
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x001E6DBC File Offset: 0x001E6DBC
		private string StageNameSafe
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001857)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.AnimationStage::get_StageNameSafe()

 ---> System.Exception: Inconsistent stack size at IL_0004
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x001E6DF0 File Offset: 0x001E6DF0
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001858)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.AnimationStage::ToString()

 ---> System.Exception: Inconsistent stack size at IL_001B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x04009675 RID: 38517
		private readonly StaticValueCache<t54798> _cache;

		// Token: 0x04009676 RID: 38518
		private string _stageName;
	}
}
