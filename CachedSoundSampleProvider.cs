using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NAudio.Wave;

namespace ExileCore2
{
	// Token: 0x020000CF RID: 207
	internal class CachedSoundSampleProvider : ISampleProvider
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x001AECB4 File Offset: 0x001AECB4
		public CachedSoundSampleProvider(CachedSound cachedSound)
		{
			this;
			cachedSound;
			this;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x001AECC4 File Offset: 0x001AECC4
		public int Read(float[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000603)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.CachedSoundSampleProvider::Read(System.Single[],System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_001C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x001AED64 File Offset: 0x001AED64
		public WaveFormat WaveFormat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000353 RID: 851
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CachedSound <cachedSound>P;

		// Token: 0x04000354 RID: 852
		private int _position;
	}
}
