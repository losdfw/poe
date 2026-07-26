using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003A1 RID: 929
	[NullableContext(1)]
	[Nullable(0)]
	public class SpiritData : IEquatable<SpiritData>
	{
		// Token: 0x06001921 RID: 6433 RVA: 0x001E8A30 File Offset: 0x001E8A30
		public SpiritData(int ReservedFlat, float ReservedFraction, int Max)
		{
			this;
			ReservedFlat;
			this;
			ReservedFraction;
			this;
			Max;
			this;
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x001E8A50 File Offset: 0x001E8A50
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SpiritData).TypeHandle;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x001E8A5C File Offset: 0x001E8A5C
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x001E8A64 File Offset: 0x001E8A64
		public int ReservedFlat
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

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x001E8A70 File Offset: 0x001E8A70
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x001E8A78 File Offset: 0x001E8A78
		public float ReservedFraction
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

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x001E8A84 File Offset: 0x001E8A84
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x001E8A8C File Offset: 0x001E8A8C
		public int Max
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x001E8A98 File Offset: 0x001E8A98
		public int Reserved
		{
			get
			{
				return (int)(this * this) + this;
			}
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x001E8AB8 File Offset: 0x001E8AB8
		[CompilerGenerated]
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600192A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.SpiritData::ToString()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x001E8B04 File Offset: 0x001E8B04
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			/*
An exception occurred when decompiling this method (0600192B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.SpiritData::PrintMembers(System.Text.StringBuilder)

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

		// Token: 0x0600192C RID: 6444 RVA: 0x001E8BB4 File Offset: 0x001E8BB4
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(SpiritData left, SpiritData right)
		{
			left;
			return right == 0;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x001E8BC0 File Offset: 0x001E8BC0
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(SpiritData left, SpiritData right)
		{
			/*
An exception occurred when decompiling this method (0600192D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.SpiritData::op_Equality(ExileCore2.PoEMemory.Components.SpiritData,ExileCore2.PoEMemory.Components.SpiritData)

 ---> System.Exception: Inconsistent stack size at IL_0002
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x001E8BD8 File Offset: 0x001E8BD8
		[CompilerGenerated]
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600192E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.Components.SpiritData::GetHashCode()

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

		// Token: 0x0600192F RID: 6447 RVA: 0x001E8C3C File Offset: 0x001E8C3C
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			this;
			return obj is SpiritData;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x001E8C4C File Offset: 0x001E8C4C
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(SpiritData other)
		{
			/*
An exception occurred when decompiling this method (06001930)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.Components.SpiritData::Equals(ExileCore2.PoEMemory.Components.SpiritData)

 ---> System.Exception: Inconsistent stack size at IL_0002
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x001E8CC8 File Offset: 0x001E8CC8
		[CompilerGenerated]
		protected SpiritData(SpiritData original)
		{
			this;
			this;
			original;
			this;
			original;
			this;
			original;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x001E8CF8 File Offset: 0x001E8CF8
		[CompilerGenerated]
		public void Deconstruct(out int ReservedFlat, out float ReservedFraction, out int Max)
		{
			ReservedFlat = this;
			ReservedFraction = this;
			Max = this;
		}
	}
}
