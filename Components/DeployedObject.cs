using System;
using ExileCore2.PoEMemory.MemoryObjects;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200038D RID: 909
	public class DeployedObject : StructuredRemoteMemoryObject<ActorDeployedObjectOffsets>
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x001E7BDC File Offset: 0x001E7BDC
		public uint ObjectId
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x001E7BEC File Offset: 0x001E7BEC
		public ushort SkillKey
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x001E7BFC File Offset: 0x001E7BFC
		public ushort SkillKey2
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x001E7C0C File Offset: 0x001E7C0C
		public Entity Entity
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.Entity ExileCore2.PoEMemory.Components.DeployedObject::get_Entity()

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

		// Token: 0x060018CF RID: 6351 RVA: 0x001E7C38 File Offset: 0x001E7C38
		public override string ToString()
		{
			7;
			4;
			this;
			"/";
			this;
			" -> ";
			this;
			"(";
			this;
			return ")";
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x001E7CC4 File Offset: 0x001E7CC4
		public DeployedObject()
		{
			this;
		}

		// Token: 0x04009686 RID: 38534
		private Entity _entity;
	}
}
