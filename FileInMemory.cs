using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001B2 RID: 434
	public abstract class FileInMemory
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x001C33D0 File Offset: 0x001C33D0
		protected FileInMemory(IMemory m, Func<long> address)
		{
			this;
			this;
			m;
			this;
			address;
			this;
			address;
			this;
			this;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x001C3408 File Offset: 0x001C3408
		public IMemory M
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x001C3410 File Offset: 0x001C3410
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x001C3418 File Offset: 0x001C3418
		public long Address
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			protected set
			{
				this;
				value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x001C3424 File Offset: 0x001C3424
		public string FileName
		{
			get
			{
				this;
				this + 8L;
				return this;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x001C344C File Offset: 0x001C344C
		protected long FirstRecord
		{
			get
			{
				this;
				this + 40L;
				return new int[1];
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x001C3470 File Offset: 0x001C3470
		protected long LastRecord
		{
			get
			{
				this;
				this + 40L;
				return new int[] { 8 };
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x001C3498 File Offset: 0x001C3498
		protected long FirstArrItem
		{
			get
			{
				this;
				this + 40L;
				return new int[] { 32 };
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x001C34C0 File Offset: 0x001C34C0
		protected long LastArrItem
		{
			get
			{
				this;
				this + 40L;
				return new int[] { 40 };
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x001C34E8 File Offset: 0x001C34E8
		protected virtual int NumberOfRecords
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000BE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.FileInMemory::get_NumberOfRecords()

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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x001C3514 File Offset: 0x001C3514
		protected virtual long RecordLength
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000BE3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 ExileCore2.PoEMemory.FileInMemory::get_RecordLength()

 ---> System.Exception: Inconsistent stack size at IL_0009
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x001C3554 File Offset: 0x001C3554
		protected virtual int? ArrayPointerStride
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000BE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> ExileCore2.PoEMemory.FileInMemory::get_ArrayPointerStride()

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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x001C3654 File Offset: 0x001C3654
		protected IEnumerable<long> RecordAddresses()
		{
			-2;
			return this;
		}

		// Token: 0x04009128 RID: 37160
		protected readonly Func<long> FAddress;

		// Token: 0x04009129 RID: 37161
		protected readonly CachedValue<long> FAddressCache;
	}
}
