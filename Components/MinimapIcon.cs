using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003A9 RID: 937
	public class MinimapIcon : Component
	{
		// Token: 0x06001963 RID: 6499 RVA: 0x001E9324 File Offset: 0x001E9324
		public MinimapIcon()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x001E933C File Offset: 0x001E933C
		public bool IsVisible
		{
			get
			{
				return this == 0;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x001E9354 File Offset: 0x001E9354
		public bool IsHide
		{
			get
			{
				return this == 1;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x001E936C File Offset: 0x001E936C
		[Obsolete]
		public string TestString
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x001E939C File Offset: 0x001E939C
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001967)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.MinimapIcon::get_Name()

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

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x001E9410 File Offset: 0x001E9410
		public MinimapIconDat IconDat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040096AD RID: 38573
		private readonly FrameCache<t71040> _cachedValue;
	}
}
