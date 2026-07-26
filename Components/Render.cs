using System;
using System.Numerics;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003BD RID: 957
	public class Render : Component
	{
		// Token: 0x060019F3 RID: 6643 RVA: 0x001EA854 File Offset: 0x001EA854
		public Render()
		{
			this;
			this;
			this;
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x001EA878 File Offset: 0x001EA878
		private t83754 RenderStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x001EA888 File Offset: 0x001EA888
		public float X
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x001EA898 File Offset: 0x001EA898
		public float Y
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x001EA8A8 File Offset: 0x001EA8A8
		public float Z
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x001EA8B8 File Offset: 0x001EA8B8
		public Vector3 Pos
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x001EA8C8 File Offset: 0x001EA8C8
		public Vector3 InteractCenter
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x001EA8E8 File Offset: 0x001EA8E8
		public float Height
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_Height()

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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x001EA910 File Offset: 0x001EA910
		public float UnclampedHeight
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x001EA920 File Offset: 0x001EA920
		public string Name
		{
			get
			{
				0;
				2;
				"Render";
				this;
				return this;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x001EA980 File Offset: 0x001EA980
		public string NameNoCache
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x001EA998 File Offset: 0x001EA998
		public Vector3 Rotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x001EA9A8 File Offset: 0x001EA9A8
		public Vector3 Bounds
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x001EA9B8 File Offset: 0x001EA9B8
		[Obsolete]
		public Vector3 MeshRotation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x001EA9C8 File Offset: 0x001EA9C8
		public float RotationInDegrees
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_RotationInDegrees()

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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x001EA9E0 File Offset: 0x001EA9E0
		public float TerrainHeight
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A02)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single ExileCore2.PoEMemory.Components.Render::get_TerrainHeight()

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

		// Token: 0x040096BF RID: 38591
		private readonly CachedValue<t83754> _cachedValue;
	}
}
