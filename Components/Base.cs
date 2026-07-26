using System;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200037F RID: 895
	public class Base : Component
	{
		// Token: 0x06001874 RID: 6260 RVA: 0x001E7184 File Offset: 0x001E7184
		public Base()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x001E71BC File Offset: 0x001E71BC
		private t29310 BaseStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x001E71CC File Offset: 0x001E71CC
		public ItemInfoData Info
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x001E71DC File Offset: 0x001E71DC
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001877)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.Base::get_Name()

 ---> System.Exception: Unknown OpCode: Stloc_0
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 1115
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x001E720C File Offset: 0x001E720C
		public string FlavourText
		{
			get
			{
				this;
				this;
				this + 10L;
				return 1;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x001E7240 File Offset: 0x001E7240
		public byte ItemCellsSizeX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x001E7254 File Offset: 0x001E7254
		public byte ItemCellsSizeY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x001E7268 File Offset: 0x001E7268
		public byte CurrencyItemLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x001E727C File Offset: 0x001E727C
		public Influence InfluenceFlag
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x001E7290 File Offset: 0x001E7290
		public bool isShaper
		{
			get
			{
				return (this & 1) == 1;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x001E72A0 File Offset: 0x001E72A0
		public bool isElder
		{
			get
			{
				return (this & 2) == 2;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x001E72B0 File Offset: 0x001E72B0
		public bool isCrusader
		{
			get
			{
				return (this & 4) == 4;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x001E72C0 File Offset: 0x001E72C0
		public bool isHunter
		{
			get
			{
				return (this & 16) == 16;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x001E72D0 File Offset: 0x001E72D0
		public bool isRedeemer
		{
			get
			{
				return (this & 8) == 8;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x001E72E0 File Offset: 0x001E72E0
		public bool isWarlord
		{
			get
			{
				return (this & 32) == 32;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x001E72F0 File Offset: 0x001E72F0
		public bool isSynthesized
		{
			get
			{
				return this + this == 1;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x001E7310 File Offset: 0x001E7310
		public bool isCorrupted
		{
			get
			{
				return (this & 1) == 1;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x001E7328 File Offset: 0x001E7328
		public int UnspentAbsorbedCorruption
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x001E733C File Offset: 0x001E733C
		public int ScourgedTier
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x001E7350 File Offset: 0x001E7350
		public string PublicPrice
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x04009679 RID: 38521
		private readonly CachedValue<t29310> _cachedValue;

		// Token: 0x0400967A RID: 38522
		private readonly CachedValue<ItemInfoData> _itemInfoData;

		// Token: 0x0400967B RID: 38523
		private string _name;
	}
}
