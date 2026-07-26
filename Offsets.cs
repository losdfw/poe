using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001BE RID: 446
	public class Offsets
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x001C5E00 File Offset: 0x001C5E00
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x001C5E08 File Offset: 0x001C5E08
		public long AreaChangeCount
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x001C5E14 File Offset: 0x001C5E14
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x001C5E1C File Offset: 0x001C5E1C
		public long Base
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x001C5E28 File Offset: 0x001C5E28
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x001C5E30 File Offset: 0x001C5E30
		public string ExeName
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x001C5E3C File Offset: 0x001C5E3C
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x001C5E44 File Offset: 0x001C5E44
		public long FileRoot
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x001C5E50 File Offset: 0x001C5E50
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x001C5E58 File Offset: 0x001C5E58
		public long GameStateOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x001C5E64 File Offset: 0x001C5E64
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x001C5E6C File Offset: 0x001C5E6C
		public long DiagnosticInfoTypeOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x001C5E78 File Offset: 0x001C5E78
		public Dictionary<OffsetsName, long> DoPatternScans(IMemory m)
		{
			/*
An exception occurred when decompiling this method (06000CD4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.OffsetsName,System.Int64> ExileCore2.PoEMemory.Offsets::DoPatternScans(ExileCore2.Shared.Interfaces.IMemory)

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

		// Token: 0x06000CD5 RID: 3285 RVA: 0x001C610C File Offset: 0x001C610C
		public Offsets()
		{
			this;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x001C6118 File Offset: 0x001C6118
		// Note: this type is marked as 'beforefieldinit'.
		static Offsets()
		{
			/*
An exception occurred when decompiling this method (06000CD6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Offsets::.cctor()

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

		// Token: 0x06000CD7 RID: 3287 RVA: 0x001C626C File Offset: 0x001C626C
		[CompilerGenerated]
		internal static long <DoPatternScans>g__ReadRelativeAddress|38_2(StringPattern pattern, OffsetsName offsetName, ref Offsets.<>c__DisplayClass38_0)
		{
			/*
An exception occurred when decompiling this method (06000CD7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 ExileCore2.PoEMemory.Offsets::<DoPatternScans>g__ReadRelativeAddress|38_2(ExileCore2.PoEMemory.StringPattern,ExileCore2.Shared.Enums.OffsetsName,ExileCore2.PoEMemory.Offsets/<>c__DisplayClass38_0&)

 ---> System.Exception: Inconsistent stack size at IL_001D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040091AF RID: 37295
		public static readonly Offsets Regular;

		// Token: 0x040091B0 RID: 37296
		public static readonly Offsets Korean;

		// Token: 0x040091B1 RID: 37297
		public static readonly Offsets Steam;

		// Token: 0x040091B2 RID: 37298
		public static readonly Offsets Epic;

		// Token: 0x040091B3 RID: 37299
		private static readonly Pattern basePtrPattern;

		// Token: 0x040091B4 RID: 37300
		private static readonly StringPattern FileRootPattern;

		// Token: 0x040091B5 RID: 37301
		private static readonly StringPattern AreaChangePattern;

		// Token: 0x040091B6 RID: 37302
		private static readonly Pattern isLoadingScreenPattern;

		// Token: 0x040091B7 RID: 37303
		private static readonly StringPattern GameStatePattern;

		// Token: 0x040091B8 RID: 37304
		private static readonly StringPattern DiagnosticInfoTypePattern;

		// Token: 0x040091B9 RID: 37305
		private static readonly StringPattern BlackBarSizePattern;

		// Token: 0x040091BA RID: 37306
		private static readonly StringPattern TerrainRotationSelectorPattern;

		// Token: 0x040091BB RID: 37307
		private static readonly StringPattern TerrainRotationHelperPattern;

		// Token: 0x040091BC RID: 37308
		private static readonly StringPattern InputModePattern;
	}
}
