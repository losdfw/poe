using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace ExileCore2
{
	// Token: 0x020000CD RID: 205
	internal class AudioPlaybackEngine : IDisposable
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x001AEA10 File Offset: 0x001AEA10
		public AudioPlaybackEngine(int sampleRate = 44100, int channelCount = 2)
		{
			this;
			this;
			this;
			sampleRate;
			channelCount;
			1;
			this;
			this;
			0;
			this;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x001AEA6C File Offset: 0x001AEA6C
		private ISampleProvider ConvertToRightChannelCount(ISampleProvider input)
		{
			/*
An exception occurred when decompiling this method (060005F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling NAudio.Wave.ISampleProvider ExileCore2.AudioPlaybackEngine::ConvertToRightChannelCount(NAudio.Wave.ISampleProvider)

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x001AEAE0 File Offset: 0x001AEAE0
		public void PlaySound(CachedSound sound, float volume)
		{
			/*
An exception occurred when decompiling this method (060005F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.AudioPlaybackEngine::PlaySound(ExileCore2.CachedSound,System.Single)

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

		// Token: 0x060005FA RID: 1530 RVA: 0x001AEB30 File Offset: 0x001AEB30
		public void PlaySound(CachedSound sound)
		{
			this;
			sound;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x001AEB40 File Offset: 0x001AEB40
		private void AddMixerInput(ISampleProvider input)
		{
			this;
			this;
			input;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x001AEB58 File Offset: 0x001AEB58
		public void Dispose()
		{
			this;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x001AEB68 File Offset: 0x001AEB68
		public void SetVolume(float volume)
		{
			this;
			volume;
		}

		// Token: 0x0400034F RID: 847
		private readonly IWavePlayer _outputDevice;

		// Token: 0x04000350 RID: 848
		private readonly MixingSampleProvider _mixer;
	}
}
