using System;
using System.Diagnostics;

namespace ExileCore2
{
	// Token: 0x020000D4 RID: 212
	public static class Time
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x001AF778 File Offset: 0x001AF778
		private static Stopwatch Stopwatch { get; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x001AF780 File Offset: 0x001AF780
		public static double TotalMilliseconds
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000615)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ExileCore2.Time::get_TotalMilliseconds()

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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x001AF7A0 File Offset: 0x001AF7A0
		public static long ElapsedMilliseconds
		{
			get
			{
				return Time.Stopwatch;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x001AF7AC File Offset: 0x001AF7AC
		public static TimeSpan Elapsed
		{
			get
			{
				return Time.Stopwatch;
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x001AF7B8 File Offset: 0x001AF7B8
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Stopwatch.StartNew();
		}
	}
}
