using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ExileCore2
{
	// Token: 0x020000D0 RID: 208
	internal class StatCollector
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x001AED74 File Offset: 0x001AED74
		public static void Run(CancellationToken cancellationToken)
		{
			goto IL_0000;
			for (;;)
			{
				IL_0000:
				goto IL_0000;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x001AF554 File Offset: 0x001AF554
		private static bool ValidateServerCert(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			/*
An exception occurred when decompiling this method (06000606)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.StatCollector::ValidateServerCert(System.Object,System.Security.Cryptography.X509Certificates.X509Certificate,System.Security.Cryptography.X509Certificates.X509Chain,System.Net.Security.SslPolicyErrors)

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x001AF5EC File Offset: 0x001AF5EC
		public StatCollector()
		{
			this;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x001AF5F8 File Offset: 0x001AF5F8
		// Note: this type is marked as 'beforefieldinit'.
		static StatCollector()
		{
			new byte[32];
			new byte[32];
		}

		// Token: 0x04000355 RID: 853
		private static readonly byte[] AbortHash;

		// Token: 0x04000356 RID: 854
		private static readonly byte[] RequestHash;

		// Token: 0x020000D1 RID: 209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000357 RID: 855
			public static RemoteCertificateValidationCallback <0>__ValidateServerCert;
		}
	}
}
