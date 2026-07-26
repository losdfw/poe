using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003B0 RID: 944
	public class ObjectMagicProperties : Component
	{
		// Token: 0x06001998 RID: 6552 RVA: 0x001E9A78 File Offset: 0x001E9A78
		public ObjectMagicProperties()
		{
			this;
			this;
			this;
			this;
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x001E9AA4 File Offset: 0x001E9AA4
		private t48307 ObjectMagicPropertiesOffsets
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x001E9AB4 File Offset: 0x001E9AB4
		public MonsterRarity Rarity
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600199A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.Enums.MonsterRarity ExileCore2.PoEMemory.Components.ObjectMagicProperties::get_Rarity()

 ---> System.Exception: Inconsistent stack size at IL_000D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x001E9AE8 File Offset: 0x001E9AE8
		public long ModsHash
		{
			get
			{
				return this + this + this;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x001E9B1C File Offset: 0x001E9B1C
		public List<string> Mods
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600199C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.String> ExileCore2.PoEMemory.Components.ObjectMagicProperties::get_Mods()

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x001E9CA8 File Offset: 0x001E9CA8
		public List<string> ImplicitMods
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600199D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.String> ExileCore2.PoEMemory.Components.ObjectMagicProperties::get_ImplicitMods()

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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x001E9E04 File Offset: 0x001E9E04
		public List<ItemMod> ImplicitModData
		{
			get
			{
				this;
				this;
				this;
				return null;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x001E9E3C File Offset: 0x001E9E3C
		public List<ItemMod> ExplicitModData
		{
			get
			{
				this;
				this;
				this;
				return null;
			}
		}

		// Token: 0x040096B3 RID: 38579
		private readonly CachedValue<t48307> _CachedValue;

		// Token: 0x040096B4 RID: 38580
		private long _ModsHash;

		// Token: 0x040096B5 RID: 38581
		private readonly List<string> _ModNamesList;
	}
}
