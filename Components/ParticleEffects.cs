using System;
using System.Collections.Generic;
using System.Numerics;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003B3 RID: 947
	public class ParticleEffects : Component
	{
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x001E9EE0 File Offset: 0x001E9EE0
		public Matrix4x4 Matrix
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x001E9EFC File Offset: 0x001E9EFC
		public Vector3 Scale
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector3 ExileCore2.PoEMemory.Components.ParticleEffects::get_Scale()

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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x001E9F28 File Offset: 0x001E9F28
		public List<ParticleEffects.ParticleEffect> Effects
		{
			get
			{
				this;
				this;
				this + 48L;
				return 40;
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x001E9F54 File Offset: 0x001E9F54
		public ParticleEffects()
		{
			this;
		}

		// Token: 0x020003B4 RID: 948
		public class ParticleEffect : RemoteMemoryObject
		{
			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x060019A9 RID: 6569 RVA: 0x001E9F60 File Offset: 0x001E9F60
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id1
			{
				get
				{
					this;
					return this + 8L;
				}
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x001E9F78 File Offset: 0x001E9F78
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id2
			{
				get
				{
					this;
					return this + 12L;
				}
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x060019AB RID: 6571 RVA: 0x001E9F90 File Offset: 0x001E9F90
			[Obsolete("Subject to change if I ever figure out what these are")]
			public int Id3
			{
				get
				{
					this;
					return this + 36L;
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x060019AC RID: 6572 RVA: 0x001E9FA8 File Offset: 0x001E9FA8
			public string PetNames
			{
				get
				{
					this;
					this + 16L;
					int[] array = new int[] { 24, 8 };
					return this;
				}
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x001E9FDC File Offset: 0x001E9FDC
			public ParticleEffect()
			{
				this;
			}
		}
	}
}
