using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace ExileCore2
{
	// Token: 0x020000CB RID: 203
	public static class SortedListExtensions
	{
		// Token: 0x060005EB RID: 1515 RVA: 0x001AE6D4 File Offset: 0x001AE6D4
		public static bool TryGetLowerBound(this SortedList<long, byte[]> list, long key, [NotNullWhen(true)] out long lowerBoundKey, [NotNullWhen(true)] out byte[] lowerBoundValue)
		{
			/*
An exception occurred when decompiling this method (060005EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.SortedListExtensions::TryGetLowerBound(System.Collections.Generic.SortedList`2<System.Int64,System.Byte[]>,System.Int64,System.Int64&,System.Byte[]&)

 ---> System.Exception: Inconsistent stack size at IL_000D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x001AE75C File Offset: 0x001AE75C
		private static Func<TSource, TResult> GetGetter<TSource, TResult>(FieldInfo field)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(TSource));
			return Expression.Lambda<Func<TSource, TResult>>(Expression.Field(parameterExpression, field), new ParameterExpression[] { parameterExpression }).Compile();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x001AE79C File Offset: 0x001AE79C
		// Note: this type is marked as 'beforefieldinit'.
		static SortedListExtensions()
		{
			typeof(SortedList<long, byte[]>).TypeHandle;
			"keys";
			36;
			typeof(SortedList<long, byte[]>).TypeHandle;
			"_size";
			36;
			typeof(SortedList<long, byte[]>).TypeHandle;
			"comparer";
			36;
		}

		// Token: 0x04000348 RID: 840
		private static readonly Func<SortedList<long, byte[]>, long[]> KeysGetter;

		// Token: 0x04000349 RID: 841
		private static readonly Func<SortedList<long, byte[]>, int> SizeGetter;

		// Token: 0x0400034A RID: 842
		private static readonly Func<SortedList<long, byte[]>, IComparer<long>> ComparerGetter;
	}
}
