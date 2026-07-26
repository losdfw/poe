using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003CE RID: 974
	public class Stats : Component
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x001EB4D8 File Offset: 0x001EB4D8
		public Stats()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x001EB534 File Offset: 0x001EB534
		public new long OwnerAddress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x001EB548 File Offset: 0x001EB548
		public Dictionary<GameStat, int> StatDictionary
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x001EB558 File Offset: 0x001EB558
		public long StatsCount
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x001EB568 File Offset: 0x001EB568
		public int ActiveWeaponSetIndex
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x001EB57C File Offset: 0x001EB57C
		private Dictionary<GameStat, int> ParseStats(SubStatsComponentOffsets subStats, bool secondary)
		{
			/*
An exception occurred when decompiling this method (06001A4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.GameStat,System.Int32> ExileCore2.PoEMemory.Components.Stats::ParseStats(GameOffsets2.SubStatsComponentOffsets,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040096D4 RID: 38612
		private readonly CachedValue<StatsComponentOffsets> _statsValue;

		// Token: 0x040096D5 RID: 38613
		private readonly CachedValue<Dictionary<GameStat, int>> _statDictionary;

		// Token: 0x040096D6 RID: 38614
		private readonly Dictionary<GameStat, int> _mainStatDictionary;

		// Token: 0x040096D7 RID: 38615
		private readonly Dictionary<GameStat, int> _secondaryStatDictionary;
	}
}
