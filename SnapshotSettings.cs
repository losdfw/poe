using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x020000C6 RID: 198
	[Submenu(CollapsedByDefault = true)]
	public class SnapshotSettings
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x001ADDA4 File Offset: 0x001ADDA4
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x001ADDAC File Offset: 0x001ADDAC
		[JsonIgnore]
		public ButtonNode TakeSnapshot
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x001ADDB8 File Offset: 0x001ADDB8
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x001ADDC0 File Offset: 0x001ADDC0
		[JsonIgnore]
		public ButtonNode ClearSnapshots
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x001ADDCC File Offset: 0x001ADDCC
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x001ADDD4 File Offset: 0x001ADDD4
		public HotkeyNodeV2 TakeSnapshotHotkey
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x001ADDE0 File Offset: 0x001ADDE0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x001ADDE8 File Offset: 0x001ADDE8
		public ToggleNode FreezeProcessDuringSnapshot
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x001ADDF4 File Offset: 0x001ADDF4
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x001ADDFC File Offset: 0x001ADDFC
		[JsonIgnore]
		public SnapshotSettings.RenderList SnapshotList
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

		// Token: 0x060005E2 RID: 1506 RVA: 0x001ADE08 File Offset: 0x001ADE08
		public SnapshotSettings()
		{
			this;
			this;
			this;
			0;
			this;
			0;
			this;
			this;
		}

		// Token: 0x020000C7 RID: 199
		[Submenu(RenderMethod = "Render")]
		public class RenderList
		{
			// Token: 0x060005E3 RID: 1507 RVA: 0x001ADE58 File Offset: 0x001ADE58
			public void Render()
			{
				/*
An exception occurred when decompiling this method (060005E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.SnapshotSettings/RenderList::Render()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x001AE124 File Offset: 0x001AE124
			public RenderList()
			{
				this;
			}
		}
	}
}
