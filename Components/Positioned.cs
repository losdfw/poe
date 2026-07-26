using System;
using System.Numerics;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003B9 RID: 953
	public class Positioned : Component
	{
		// Token: 0x060019D8 RID: 6616 RVA: 0x001EA65C File Offset: 0x001EA65C
		public Positioned()
		{
			this;
			this;
			this;
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x001EA680 File Offset: 0x001EA680
		public PositionedComponentOffsets PositionedStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x001EA690 File Offset: 0x001EA690
		public new long OwnerAddress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x001EA6A0 File Offset: 0x001EA6A0
		public int GridX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x001EA6B0 File Offset: 0x001EA6B0
		public int GridY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x001EA6C0 File Offset: 0x001EA6C0
		public Vector2 GridPos
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x001EA6D8 File Offset: 0x001EA6D8
		public Vector2i GridPosI
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x001EA6EC File Offset: 0x001EA6EC
		public Vector2 WorldPos
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x001EA6FC File Offset: 0x001EA6FC
		public Vector2 TravelTarget
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x001EA70C File Offset: 0x001EA70C
		public Vector2 TravelStart
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x001EA71C File Offset: 0x001EA71C
		public float TravelProgress
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x001EA72C File Offset: 0x001EA72C
		public Vector2 TravelOffset
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x001EA73C File Offset: 0x001EA73C
		public Vector2i GridPosition
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x001EA74C File Offset: 0x001EA74C
		public float Rotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x001EA75C File Offset: 0x001EA75C
		public float WorldX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x001EA76C File Offset: 0x001EA76C
		public float WorldY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x001EA77C File Offset: 0x001EA77C
		public float RotationDeg
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Positioned::get_RotationDeg()

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
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x001EA78C File Offset: 0x001EA78C
		public byte Reaction
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x001EA79C File Offset: 0x001EA79C
		public PositionedFlags Flags
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x001EA7AC File Offset: 0x001EA7AC
		public int Size
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x001EA7BC File Offset: 0x001EA7BC
		public float Scale
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040096BE RID: 38590
		private readonly CachedValue<PositionedComponentOffsets> _cachedValue;
	}
}
