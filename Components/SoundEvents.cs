using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003C9 RID: 969
	public class SoundEvents : Component
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x001EB164 File Offset: 0x001EB164
		public List<SoundEvents.SoundEvent> Events
		{
			get
			{
				this;
				this;
				this + 88L;
				32;
				return this;
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x001EB1A0 File Offset: 0x001EB1A0
		public SoundEvents()
		{
			this;
		}

		// Token: 0x020003CA RID: 970
		public class SoundEvent : RemoteMemoryObject
		{
			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06001A36 RID: 6710 RVA: 0x001EB1AC File Offset: 0x001EB1AC
			public string Name
			{
				get
				{
					this;
					this + 64L;
					return this;
				}
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x001EB1D0 File Offset: 0x001EB1D0
			public override string ToString()
			{
				/*
An exception occurred when decompiling this method (06001A37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.SoundEvents/SoundEvent::ToString()

 ---> System.Exception: Inconsistent stack size at IL_000C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}

			// Token: 0x06001A38 RID: 6712 RVA: 0x001EB1F4 File Offset: 0x001EB1F4
			public SoundEvent()
			{
				this;
			}
		}
	}
}
