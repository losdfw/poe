using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003A4 RID: 932
	public class LocalStats : Component
	{
		// Token: 0x06001950 RID: 6480 RVA: 0x001E9064 File Offset: 0x001E9064
		public LocalStats()
		{
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x001E90B4 File Offset: 0x001E90B4
		public Dictionary<GameStat, int> StatDictionary
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x001E90C4 File Offset: 0x001E90C4
		public Dictionary<GameStat, int> ParseStats()
		{
			/*
An exception occurred when decompiling this method (06001952)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.GameStat,System.Int32> ExileCore2.PoEMemory.Components.LocalStats::ParseStats()

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x001E9168 File Offset: 0x001E9168
		public int GetStatValue(GameStat stat)
		{
			/*
An exception occurred when decompiling this method (06001953)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.LocalStats::GetStatValue(ExileCore2.Shared.Enums.GameStat)

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040096A6 RID: 38566
		private readonly CachedValue<t95980> _localStatsValue;

		// Token: 0x040096A7 RID: 38567
		private readonly CachedValue<Dictionary<GameStat, int>> _statDictionary;

		// Token: 0x040096A8 RID: 38568
		private readonly Dictionary<GameStat, int> statDictionary;
	}
}
