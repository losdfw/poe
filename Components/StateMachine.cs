using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003CC RID: 972
	public class StateMachine : Component
	{
		// Token: 0x06001A3D RID: 6717 RVA: 0x001EB268 File Offset: 0x001EB268
		public StateMachine()
		{
			this;
			this;
			this;
			this;
			this;
			null;
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x001EB2A8 File Offset: 0x001EB2A8
		public IList<StateMachineState> States
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x001EB2B8 File Offset: 0x001EB2B8
		public bool CanBeTarget
		{
			get
			{
				return this + this == 1;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x001EB2D8 File Offset: 0x001EB2D8
		public bool InTarget
		{
			get
			{
				return this + this == 1;
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x001EB2F8 File Offset: 0x001EB2F8
		public IList<StateMachineState> ReadStates()
		{
			/*
An exception occurred when decompiling this method (06001A41)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<ExileCore2.PoEMemory.Components.StateMachineState> ExileCore2.PoEMemory.Components.StateMachine::ReadStates()

 ---> System.Exception: Inconsistent stack size at IL_0004
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x001EB314 File Offset: 0x001EB314
		private IList<StateMachineState> ReadStates(IList<StateMachineState> lastValue)
		{
			/*
An exception occurred when decompiling this method (06001A42)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<ExileCore2.PoEMemory.Components.StateMachineState> ExileCore2.PoEMemory.Components.StateMachine::ReadStates(System.Collections.Generic.IList`1<ExileCore2.PoEMemory.Components.StateMachineState>)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x040096D0 RID: 38608
		private readonly CachedValue<StateMachineComponentOffsets> _stateMachine;

		// Token: 0x040096D1 RID: 38609
		private readonly CachedValue<IList<StateMachineState>> _statesCache;
	}
}
