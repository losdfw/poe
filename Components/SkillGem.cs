using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003C3 RID: 963
	public class SkillGem : Component
	{
		// Token: 0x06001A10 RID: 6672 RVA: 0x001EAB58 File Offset: 0x001EAB58
		public SkillGem()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x001EAB90 File Offset: 0x001EAB90
		public int Level
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x001EABA4 File Offset: 0x001EABA4
		public uint TotalExpGained
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x001EABB8 File Offset: 0x001EABB8
		public uint ExperiencePrevLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x001EABCC File Offset: 0x001EABCC
		public uint ExperienceMaxLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x001EABE0 File Offset: 0x001EABE0
		public uint ExperienceToNextLevel
		{
			get
			{
				return this - this;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x001EABF0 File Offset: 0x001EABF0
		public int MaxLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x001EAC04 File Offset: 0x001EAC04
		public int SocketColor
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x001EAC18 File Offset: 0x001EAC18
		public SkillGemDat SkillGemDat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x001EAC40 File Offset: 0x001EAC40
		public GemEffect GemEffect
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.GemEffect ExileCore2.PoEMemory.Components.SkillGem::get_GemEffect()

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

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x001EAC94 File Offset: 0x001EAC94
		public GrantedEffect GrantedEffect1
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A1A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.GrantedEffect ExileCore2.PoEMemory.Components.SkillGem::get_GrantedEffect1()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x001EACA8 File Offset: 0x001EACA8
		public GrantedEffect GrantedEffect2
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A1B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.GrantedEffect ExileCore2.PoEMemory.Components.SkillGem::get_GrantedEffect2()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x001EACBC File Offset: 0x001EACBC
		public GrantedEffect GrantedEffect1HardMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.GrantedEffect ExileCore2.PoEMemory.Components.SkillGem::get_GrantedEffect1HardMode()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x001EACD0 File Offset: 0x001EACD0
		public GrantedEffect GrantedEffect2HardMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.GrantedEffect ExileCore2.PoEMemory.Components.SkillGem::get_GrantedEffect2HardMode()

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x001EACE4 File Offset: 0x001EACE4
		[Obsolete]
		public int RequiredLevel
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x001EACF4 File Offset: 0x001EACF4
		[Obsolete]
		public int GetRequiredLevel(int gemLevel)
		{
			/*
An exception occurred when decompiling this method (06001A1F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.SkillGem::GetRequiredLevel(System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0003
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040096C1 RID: 38593
		private readonly CachedValue<SkillGemOffsets> _cachedValue;

		// Token: 0x040096C2 RID: 38594
		private readonly FrameCache<GemInformation> _cachedValue2;
	}
}
