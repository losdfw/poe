using System;
using System.Collections.Concurrent;

namespace ExileCore2
{
	// Token: 0x020000A6 RID: 166
	public class PluginBridge
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x001AAC7C File Offset: 0x001AAC7C
		public T GetMethod<T>(string name) where T : class
		{
			/*
An exception occurred when decompiling this method (06000546)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T ExileCore2.PluginBridge::GetMethod<T>(System.String)

 ---> System.Exception: Inconsistent stack size at IL_0013
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x001AACB8 File Offset: 0x001AACB8
		public void SaveMethod(string name, object method)
		{
			this;
			name;
			method;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x001AACCC File Offset: 0x001AACCC
		public PluginBridge()
		{
			this;
			this;
		}

		// Token: 0x040002C9 RID: 713
		private readonly ConcurrentDictionary<string, object> _methods;
	}
}
