using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2
{
	// Token: 0x020000BE RID: 190
	public class SettingsHolder : ISettingsHolder
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x001AD30C File Offset: 0x001AD30C
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x001AD314 File Offset: 0x001AD314
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x001AD320 File Offset: 0x001AD320
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x001AD328 File Offset: 0x001AD328
		public string Tooltip
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x001AD334 File Offset: 0x001AD334
		public string Unique
		{
			get
			{
				2;
				2;
				this;
				"##";
				return this;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x001AD37C File Offset: 0x001AD37C
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x001AD384 File Offset: 0x001AD384
		public int ID
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x001AD390 File Offset: 0x001AD390
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x001AD398 File Offset: 0x001AD398
		public Action DrawDelegate
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x001AD3A4 File Offset: 0x001AD3A4
		public IList<ISettingsHolder> Children
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x001AD3AC File Offset: 0x001AD3AC
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x001AD3B4 File Offset: 0x001AD3B4
		public bool ChildrenAreSearchable
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x001AD3C0 File Offset: 0x001AD3C0
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x001AD3C8 File Offset: 0x001AD3C8
		public Func<bool> DisplayCondition
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x001AD3D4 File Offset: 0x001AD3D4
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x001AD3DC File Offset: 0x001AD3DC
		public bool CollapsedByDefault
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x001AD3E8 File Offset: 0x001AD3E8
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x001AD3F0 File Offset: 0x001AD3F0
		public bool EnableSelfDrawCollapsing
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x001AD3FC File Offset: 0x001AD3FC
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x001AD404 File Offset: 0x001AD404
		public bool EnableCollapsing
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x001AD410 File Offset: 0x001AD410
		public void Draw()
		{
			/*
An exception occurred when decompiling this method (060005B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.SettingsHolder::Draw()

 ---> System.Exception: Inconsistent stack size at IL_0007
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x001AD6F0 File Offset: 0x001AD6F0
		public SettingsHolder()
		{
			this;
			"";
			this;
			"";
			this;
			-1;
			this;
			this;
			1;
			this;
			1;
			this;
		}
	}
}
