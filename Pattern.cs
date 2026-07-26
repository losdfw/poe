using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001C1 RID: 449
	public class Pattern : IPattern
	{
		// Token: 0x06000CDC RID: 3292 RVA: 0x001C62EC File Offset: 0x001C62EC
		public Pattern(byte[] pattern, string mask, string name, int startOffset = 0)
		{
			this;
			this;
			pattern;
			this;
			mask;
			"\\s+";
			"";
			this;
			name;
			this;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x001C6324 File Offset: 0x001C6324
		public Pattern(string pattern, string mask, string name, int startOffset = 0)
		{
			/*
An exception occurred when decompiling this method (06000CDD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Pattern::.ctor(System.String,System.String,System.String,System.Int32)

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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x001C6398 File Offset: 0x001C6398
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x001C63A0 File Offset: 0x001C63A0
		public byte[] Bytes
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x001C63A8 File Offset: 0x001C63A8
		public string Mask
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x001C63B0 File Offset: 0x001C63B0
		public int StartOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}
	}
}
