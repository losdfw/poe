using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000370 RID: 880
	public class AnimationController : Component
	{
		// Token: 0x06001816 RID: 6166 RVA: 0x001E650C File Offset: 0x001E650C
		public AnimationController()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x001E6598 File Offset: 0x001E6598
		internal t98199 Structure
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x001E65A8 File Offset: 0x001E65A8
		private ActiveAnimationData ActiveAnimationData
		{
			get
			{
				this;
				this;
				this;
				return this;
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x001E65E4 File Offset: 0x001E65E4
		public float TransformProgress(float progress)
		{
			this;
			return progress;
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x001E65F8 File Offset: 0x001E65F8
		public float MaxRawAnimationProgress
		{
			get
			{
				return this - this;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x001E6614 File Offset: 0x001E6614
		public float RawNextAnimationPoint
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x001E6624 File Offset: 0x001E6624
		public float RawAnimationProgress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x001E6634 File Offset: 0x001E6634
		public float RawAnimationSpeed
		{
			get
			{
				return this * this;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x001E6650 File Offset: 0x001E6650
		public float TransformedMaxRawAnimationProgress
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x001E6660 File Offset: 0x001E6660
		public float TransformedRawNextAnimationPoint
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x001E6670 File Offset: 0x001E6670
		public float TransformedRawAnimationProgress
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x001E6680 File Offset: 0x001E6680
		public float AnimationSpeed
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x001E6690 File Offset: 0x001E6690
		public SupportedAnimationList SupportedAnimationList
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x001E66A4 File Offset: 0x001E66A4
		public string AnimationTimelineName
		{
			get
			{
				this;
				this + 8L;
				return this;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x001E66CC File Offset: 0x001E66CC
		public int CurrentAnimationId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x001E66DC File Offset: 0x001E66DC
		public int CurrentAnimationStage
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x001E66EC File Offset: 0x001E66EC
		public AnimationStageList CurrentAnimation
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001826)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Components.AnimationStageList ExileCore2.PoEMemory.Components.AnimationController::get_CurrentAnimation()

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

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x001E6740 File Offset: 0x001E6740
		public float NextAnimationPoint
		{
			get
			{
				return this / this;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x001E6750 File Offset: 0x001E6750
		public float AnimationProgress
		{
			get
			{
				return this / this;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x001E6760 File Offset: 0x001E6760
		public TimeSpan AnimationCompletesIn
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001829)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan ExileCore2.PoEMemory.Components.AnimationController::get_AnimationCompletesIn()

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x001E67A0 File Offset: 0x001E67A0
		public TimeSpan AnimationActiveFor
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600182A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.TimeSpan ExileCore2.PoEMemory.Components.AnimationController::get_AnimationActiveFor()

 ---> System.Exception: Inconsistent stack size at IL_000A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x04009662 RID: 38498
		private readonly CachedValue<Func<float, float>> _progressTransformFunc;

		// Token: 0x04009663 RID: 38499
		private readonly CachedValue<float> _animationSpeed;

		// Token: 0x04009664 RID: 38500
		private readonly CachedValue<CachedValue<SupportedAnimationList>> _supportedAnimationList;

		// Token: 0x04009665 RID: 38501
		private readonly CachedValue<t98199> _cachedValue;
	}
}
