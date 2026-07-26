using System;

namespace ExileCore2
{
	// Token: 0x02000083 RID: 131
	internal static class Limits
	{
		// Token: 0x0600047B RID: 1147 RVA: 0x001A4DA4 File Offset: 0x001A4DA4
		static Limits()
		{
			/*
An exception occurred when decompiling this method (0600047B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Limits::.cctor()

 ---> System.Exception: Inconsistent stack size at IL_001A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0400021F RID: 543
		public static readonly int ElementChildCount;

		// Token: 0x04000220 RID: 544
		public static readonly int UnicodeStringLength;

		// Token: 0x04000221 RID: 545
		public static readonly int ReadStructsArrayCount;

		// Token: 0x04000222 RID: 546
		public static readonly int ReadMemoryTimeLimit;

		// Token: 0x02000084 RID: 132
		private class LimitsInstance
		{
			// Token: 0x0600047C RID: 1148 RVA: 0x001A4F2C File Offset: 0x001A4F2C
			public LimitsInstance()
			{
				this;
			}

			// Token: 0x04000223 RID: 547
			public int? ElementChildCount;

			// Token: 0x04000224 RID: 548
			public int? UnicodeStringLength;

			// Token: 0x04000225 RID: 549
			public int? ReadStructsArrayCount;

			// Token: 0x04000226 RID: 550
			public int? ReadMemoryTimeLimit;
		}
	}
}
