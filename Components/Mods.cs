using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003AA RID: 938
	public class Mods : Component
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x001E9440 File Offset: 0x001E9440
		public Mods()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x001E9478 File Offset: 0x001E9478
		public ModsComponentOffsets ModsStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x001E9488 File Offset: 0x001E9488
		public string UniqueName
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x001E949C File Offset: 0x001E949C
		public bool Identified
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600196D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.Mods::get_Identified()

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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x001E94B4 File Offset: 0x001E94B4
		public ItemRarity ItemRarity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600196E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.Enums.ItemRarity ExileCore2.PoEMemory.Components.Mods::get_ItemRarity()

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

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x001E94CC File Offset: 0x001E94CC
		public long Hash
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600196F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 ExileCore2.PoEMemory.Components.Mods::get_Hash()

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

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x001E9524 File Offset: 0x001E9524
		public List<ItemMod> ItemMods
		{
			get
			{
				this;
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x001E9554 File Offset: 0x001E9554
		public List<ItemMod> CorruptionImplicitMods
		{
			get
			{
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x001E957C File Offset: 0x001E957C
		public List<ItemMod> ExplicitMods
		{
			get
			{
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x001E95A4 File Offset: 0x001E95A4
		public List<ItemMod> EnchantedMods
		{
			get
			{
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x001E95CC File Offset: 0x001E95CC
		public List<ItemMod> ImplicitMods
		{
			get
			{
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x001E95F4 File Offset: 0x001E95F4
		public List<ItemMod> SynthesisMods
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001975)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.ItemMod> ExileCore2.PoEMemory.Components.Mods::get_SynthesisMods()

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

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x001E9628 File Offset: 0x001E9628
		public List<Entity> GrantedSkills
		{
			get
			{
				this;
				this;
				this;
				this;
				return this;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x001E967C File Offset: 0x001E967C
		public int ItemLevel
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001977)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.Mods::get_ItemLevel()

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

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x001E9694 File Offset: 0x001E9694
		public int RequiredLevel
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001978)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.Mods::get_RequiredLevel()

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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x001E96AC File Offset: 0x001E96AC
		public bool IsUsable
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001979)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.Mods::get_IsUsable()

 ---> System.Exception: Inconsistent stack size at IL_0007
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x001E96C8 File Offset: 0x001E96C8
		public bool IsMirrored
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600197A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.Mods::get_IsMirrored()

 ---> System.Exception: Inconsistent stack size at IL_0007
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x001E96E4 File Offset: 0x001E96E4
		public bool Synthesised
		{
			get
			{
				return this > 0;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x001E96F0 File Offset: 0x001E96F0
		public int CountSynthesised
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x001E9700 File Offset: 0x001E9700
		public ItemStats ItemStats
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x001E9710 File Offset: 0x001E9710
		public List<string> HumanStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x001E9728 File Offset: 0x001E9728
		public List<string> HumanCraftedStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x001E9740 File Offset: 0x001E9740
		public List<string> HumanImpStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x001E9758 File Offset: 0x001E9758
		public List<string> FracturedStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x001E9770 File Offset: 0x001E9770
		public List<string> EnchantedStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x001E9788 File Offset: 0x001E9788
		public List<string> CrucibleStats
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x001E97A0 File Offset: 0x001E97A0
		private List<string> GetStats(StdVector array)
		{
			/*
An exception occurred when decompiling this method (06001984)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.String> ExileCore2.PoEMemory.Components.Mods::GetStats(GameOffsets2.Native.StdVector)

 ---> System.Exception: Inconsistent stack size at IL_0007
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x001E97D8 File Offset: 0x001E97D8
		private List<ItemMod> GetMods(long startOffset, long endOffset)
		{
			/*
An exception occurred when decompiling this method (06001985)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.ItemMod> ExileCore2.PoEMemory.Components.Mods::GetMods(System.Int64,System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x001E9854 File Offset: 0x001E9854
		private string GetUniqueName(StdVector source)
		{
			/*
An exception occurred when decompiling this method (06001986)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.Mods::GetUniqueName(GameOffsets2.Native.StdVector)

 ---> System.Exception: Inconsistent stack size at IL_000B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040096AE RID: 38574
		private readonly CachedValue<ModsComponentOffsets> _cachedValue;

		// Token: 0x040096AF RID: 38575
		private readonly CachedValue<t68627> _cachedStatsStruct;
	}
}
