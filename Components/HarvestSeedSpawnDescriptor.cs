using System;
using ExileCore2.PoEMemory.FilesInMemory.Harvest;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000398 RID: 920
	public class HarvestSeedSpawnDescriptor : RemoteMemoryObject
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x001E8308 File Offset: 0x001E8308
		public HarvestSeed Seed
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.Harvest.HarvestSeed ExileCore2.PoEMemory.Components.HarvestSeedSpawnDescriptor::get_Seed()

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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x001E8350 File Offset: 0x001E8350
		public int Count
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x001E8368 File Offset: 0x001E8368
		public HarvestSeedSpawnDescriptor()
		{
			this;
		}

		// Token: 0x04009693 RID: 38547
		private HarvestSeed _seed;
	}
}
