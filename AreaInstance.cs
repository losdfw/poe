using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2
{
	// Token: 0x0200002C RID: 44
	public sealed class AreaInstance
	{
		// Token: 0x06000133 RID: 307 RVA: 0x001992A4 File Offset: 0x001992A4
		public AreaInstance(WorldArea area, uint hash, int realLevel, int zoneSwitchId)
		{
			/*
An exception occurred when decompiling this method (06000133)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.AreaInstance::.ctor(ExileCore2.PoEMemory.MemoryObjects.WorldArea,System.UInt32,System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0019
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0019934C File Offset: 0x0019934C
		public int RealLevel
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00199354 File Offset: 0x00199354
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0019935C File Offset: 0x0019935C
		public int Act
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00199364 File Offset: 0x00199364
		public bool IsTown
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0019936C File Offset: 0x0019936C
		public bool IsHideout
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00199374 File Offset: 0x00199374
		public bool IsPeaceful
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0019937C File Offset: 0x0019937C
		public bool HasWaypoint
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00199384 File Offset: 0x00199384
		public uint Hash
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0019938C File Offset: 0x0019938C
		public int ZoneSwitchId
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00199394 File Offset: 0x00199394
		public WorldArea Area
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0019939C File Offset: 0x0019939C
		public string DisplayName
		{
			get
			{
				return new object[] { this, " (", this, ")" };
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013F RID: 319 RVA: 0x001993D0 File Offset: 0x001993D0
		public DateTime TimeEntered
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000140 RID: 320 RVA: 0x001993D8 File Offset: 0x001993D8
		// (set) Token: 0x06000141 RID: 321 RVA: 0x001993E0 File Offset: 0x001993E0
		public Color AreaColorName
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

		// Token: 0x06000142 RID: 322 RVA: 0x001993EC File Offset: 0x001993EC
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000142)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.AreaInstance::ToString()

 ---> System.Exception: Inconsistent stack size at IL_0016
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00199454 File Offset: 0x00199454
		public static string GetTimeString(TimeSpan timeSpent)
		{
			/*
An exception occurred when decompiling this method (06000143)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.AreaInstance::GetTimeString(System.TimeSpan)

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

		// Token: 0x0400006A RID: 106
		public static uint CurrentHash;

		// Token: 0x0400006B RID: 107
		public static uint ForceRefreshCounter;

		// Token: 0x0400006C RID: 108
		public static int ZoneSwitchCounter;
	}
}
