using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Enums;

namespace ExileCore2
{
	// Token: 0x020000A7 RID: 167
	public class PluginPanel
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x001AACE0 File Offset: 0x001AACE0
		public PluginPanel(Vector2 startDrawPoint, Direction direction = Direction.Down)
		{
			this;
			direction;
			this;
			startDrawPoint;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x001AACF4 File Offset: 0x001AACF4
		public PluginPanel(Direction direction = Direction.Down)
		{
			this;
			this;
			this;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x001AAD20 File Offset: 0x001AAD20
		public bool Used
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600054B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PluginPanel::get_Used()

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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x001AAD4C File Offset: 0x001AAD4C
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x001AAD54 File Offset: 0x001AAD54
		public Vector2 StartDrawPoint
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x001AAD60 File Offset: 0x001AAD60
		public Vector2 Margin
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x001AAD68 File Offset: 0x001AAD68
		public void WantUse(Func<bool> enabled)
		{
			this;
			enabled;
		}

		// Token: 0x040002CA RID: 714
		private readonly List<Func<bool>> _settings;
	}
}
