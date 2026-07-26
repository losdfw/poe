using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects.Heist;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000399 RID: 921
	public class HeistBlueprint : Component
	{
		// Token: 0x060018F9 RID: 6393 RVA: 0x001E8374 File Offset: 0x001E8374
		public HeistBlueprint()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x001E8398 File Offset: 0x001E8398
		public HeistBlueprintComponentOffsets BlueprintStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x001E83A8 File Offset: 0x001E83A8
		public byte AreaLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x001E83B8 File Offset: 0x001E83B8
		public bool IsConfirmed
		{
			get
			{
				return this == 1;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x001E83C8 File Offset: 0x001E83C8
		public List<HeistBlueprint.Wing> Wings
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x001E83DC File Offset: 0x001E83DC
		private List<HeistBlueprint.Wing> GetWings(NativePtrArray source)
		{
			/*
An exception occurred when decompiling this method (060018FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.Components.HeistBlueprint/Wing> ExileCore2.PoEMemory.Components.HeistBlueprint::GetWings(GameOffsets2.Native.NativePtrArray)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x04009694 RID: 38548
		private readonly CachedValue<HeistBlueprintComponentOffsets> _CachedBlueprint;

		// Token: 0x0200039A RID: 922
		public class Wing : RemoteMemoryObject
		{
			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x06001900 RID: 6400 RVA: 0x001E845C File Offset: 0x001E845C
			public List<ValueTuple<HeistJobRecord, int>> Jobs
			{
				get
				{
					this;
					return this;
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06001901 RID: 6401 RVA: 0x001E846C File Offset: 0x001E846C
			public List<HeistChestRewardTypeRecord> RewardRooms
			{
				get
				{
					this;
					return this + 32L;
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06001902 RID: 6402 RVA: 0x001E8480 File Offset: 0x001E8480
			public List<HeistNpcRecord> Crew
			{
				get
				{
					this;
					return this + 56L;
				}
			}

			// Token: 0x06001903 RID: 6403 RVA: 0x001E8494 File Offset: 0x001E8494
			private List<ValueTuple<HeistJobRecord, int>> GetJobs(long source)
			{
				/*
An exception occurred when decompiling this method (06001903)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<System.ValueTuple`2<ExileCore2.PoEMemory.MemoryObjects.Heist.HeistJobRecord,System.Int32>> ExileCore2.PoEMemory.Components.HeistBlueprint/Wing::GetJobs(System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x001E8564 File Offset: 0x001E8564
			private List<HeistChestRewardTypeRecord> GetRooms(long source)
			{
				/*
An exception occurred when decompiling this method (06001904)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.Heist.HeistChestRewardTypeRecord> ExileCore2.PoEMemory.Components.HeistBlueprint/Wing::GetRooms(System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x06001905 RID: 6405 RVA: 0x001E8618 File Offset: 0x001E8618
			private List<HeistNpcRecord> GetCrew(long source)
			{
				/*
An exception occurred when decompiling this method (06001905)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.Heist.HeistNpcRecord> ExileCore2.PoEMemory.Components.HeistBlueprint/Wing::GetCrew(System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x06001906 RID: 6406 RVA: 0x001E86D0 File Offset: 0x001E86D0
			public Wing()
			{
				this;
			}
		}
	}
}
