using System;
using ExileCore2.PoEMemory.MemoryObjects.Heist;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200039C RID: 924
	public class HeistEquipment : Component
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x001E8828 File Offset: 0x001E8828
		public HeistEquipment()
		{
			/*
An exception occurred when decompiling this method (06001911)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Components.HeistEquipment::.ctor()

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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x001E88C0 File Offset: 0x001E88C0
		public BaseItemType ItemBase
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x001E88D0 File Offset: 0x001E88D0
		public HeistJobRecord RequiredJob
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x001E88E0 File Offset: 0x001E88E0
		public int JobMinimumLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x001E88F4 File Offset: 0x001E88F4
		public HeistJobE RequiredJobE
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001915)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.Enums.HeistJobE ExileCore2.PoEMemory.Components.HeistEquipment::get_RequiredJobE()

 ---> System.Exception: Inconsistent stack size at IL_0004
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x04009698 RID: 38552
		private readonly Lazy<HeistEquipmentOffsets> _HeistEquipmentItem;

		// Token: 0x04009699 RID: 38553
		private readonly CachedValue<BaseItemType> _ItemBase;

		// Token: 0x0400969A RID: 38554
		private readonly CachedValue<HeistJobRecord> _Job;
	}
}
