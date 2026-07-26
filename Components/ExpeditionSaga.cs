using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects.Expedition;
using ExileCore2.Shared.Cache;
using GameOffsets2.Components.LeagueSpecific;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000391 RID: 913
	public class ExpeditionSaga : Component
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x001E7D70 File Offset: 0x001E7D70
		public ExpeditionSaga()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x001E7D94 File Offset: 0x001E7D94
		internal t98976 SagaStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x001E7DA4 File Offset: 0x001E7DA4
		public int AreaLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x001E7DB4 File Offset: 0x001E7DB4
		public List<ExpeditionAreaData> Areas
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.Expedition.ExpeditionAreaData> ExileCore2.PoEMemory.Components.ExpeditionSaga::get_Areas()

 ---> System.ArgumentOutOfRangeException: length ('-1') must be a non-negative value. (Parameter 'length')
Actual value was -1.
   at System.ArgumentOutOfRangeException.ThrowNegative[T](T value, String paramName)
   at System.Array.CopyImpl(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 289
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x04009687 RID: 38535
		private readonly CachedValue<t98976> _cachedValue;
	}
}
