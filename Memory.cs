using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ExileCore2.PoEMemory;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Interfaces;
using GameOffsets2.Native;
using Serilog;

namespace ExileCore2
{
	// Token: 0x02000086 RID: 134
	public class Memory : IMemory, IDisposable
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x001A4FB0 File Offset: 0x001A4FB0
		public Memory(Process process, Offsets offsets, CoreSettings coreSettings)
		{
			/*
An exception occurred when decompiling this method (0600047E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Memory::.ctor(System.Diagnostics.Process,ExileCore2.PoEMemory.Offsets,ExileCore2.CoreSettings)

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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x001A5084 File Offset: 0x001A5084
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x001A508C File Offset: 0x001A508C
		public IMemoryBackend CustomBackend
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x001A5098 File Offset: 0x001A5098
		private IMemoryBackend Backend
		{
			get
			{
				Memory memory = this;
				while ((memory = memory) != null)
				{
				}
				return this;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x001A50AC File Offset: 0x001A50AC
		private IntPtr GetWindowHandle()
		{
			/*
An exception occurred when decompiling this method (06000482)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr ExileCore2.Memory::GetWindowHandle()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x001A51C4 File Offset: 0x001A51C4
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x001A520C File Offset: 0x001A520C
		public MemoryBackendMode BackendMode
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000483)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.Interfaces.MemoryBackendMode ExileCore2.Memory::get_BackendMode()

 ---> System.Exception: Inconsistent stack size at IL_000D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06000484)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Memory::set_BackendMode(ExileCore2.Shared.Interfaces.MemoryBackendMode)

 ---> System.Exception: Inconsistent stack size at IL_0014
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x001A528C File Offset: 0x001A528C
		public IntPtr MainWindowHandle
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x001A529C File Offset: 0x001A529C
		public IntPtr OpenProcessHandle
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x001A52A4 File Offset: 0x001A52A4
		public long AddressOfProcess
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x001A52AC File Offset: 0x001A52AC
		public Dictionary<OffsetsName, long> BaseOffsets
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x001A52B4 File Offset: 0x001A52B4
		public Process Process
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x001A52BC File Offset: 0x001A52BC
		public IDisposable DisableCaching()
		{
			/*
An exception occurred when decompiling this method (0600048A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IDisposable ExileCore2.Memory::DisableCaching()

 ---> System.Exception: Inconsistent stack size at IL_000B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x001A52E0 File Offset: 0x001A52E0
		private IDisposable DisableLogging()
		{
			/*
An exception occurred when decompiling this method (0600048B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IDisposable ExileCore2.Memory::DisableLogging()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x001A5328 File Offset: 0x001A5328
		public void NotifyFrame()
		{
			this;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x001A5338 File Offset: 0x001A5338
		public string ReadString(long addr, int length = 256, bool replaceNull = true)
		{
			/*
An exception occurred when decompiling this method (0600048D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.Memory::ReadString(System.Int64,System.Int32,System.Boolean)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x001A53F8 File Offset: 0x001A53F8
		public string ReadNativeString(long address)
		{
			/*
An exception occurred when decompiling this method (0600048E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.Memory::ReadNativeString(System.Int64)

 ---> System.Exception: Inconsistent stack size at IL_0011
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x001A545C File Offset: 0x001A545C
		public string ReadStringU(long addr, int lengthBytes = 256, bool replaceNull = true)
		{
			/*
An exception occurred when decompiling this method (0600048F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.Memory::ReadStringU(System.Int64,System.Int32,System.Boolean)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x001A5538 File Offset: 0x001A5538
		public byte[] ReadMem(long addr, int size)
		{
			/*
An exception occurred when decompiling this method (06000490)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] ExileCore2.Memory::ReadMem(System.Int64,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x001A5558 File Offset: 0x001A5558
		public byte[] ReadMem(IntPtr address, int size)
		{
			/*
An exception occurred when decompiling this method (06000491)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] ExileCore2.Memory::ReadMem(System.IntPtr,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x001A5574 File Offset: 0x001A5574
		public T[] ReadMem<[IsUnmanaged] T>(long addr, int size) where T : struct, ValueType
		{
			return this.ReadMem<T>(new IntPtr(addr), size);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x001A5594 File Offset: 0x001A5594
		public T[] ReadMem<[IsUnmanaged] T>(IntPtr address, int size) where T : struct, ValueType
		{
			T[] array;
			try
			{
				bool flag = size <= 0 || address.ToInt64() <= 0L || size >= int.MaxValue / Unsafe.SizeOf<T>();
				if (flag)
				{
					array = Array.Empty<T>();
				}
				else
				{
					T[] array2 = new T[size];
					Span<byte> span = MemoryMarshal.Cast<T, byte>(array2.AsSpan<T>());
					bool flag2 = span.Length > 10000000 && this._enableLogging.Value.Value;
					if (flag2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Reading ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(span.Length);
						defaultInterpolatedStringHandler.AppendLiteral(" bytes at stack ");
						defaultInterpolatedStringHandler.AppendFormatted<StackTrace>(new StackTrace());
						DebugWindow.LogMsg(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					this.Backend.TryReadMemory(address, span);
					array = array2;
				}
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Readmem-> A: ");
				defaultInterpolatedStringHandler.AppendFormatted<IntPtr>(address);
				defaultInterpolatedStringHandler.AppendLiteral(" Size: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(size);
				defaultInterpolatedStringHandler.AppendLiteral(". ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				DebugWindow.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				throw;
			}
			return array;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x001A56E0 File Offset: 0x001A56E0
		public bool ReadMem<[IsUnmanaged] T>(IntPtr address, Span<T> target) where T : struct, ValueType
		{
			bool flag2;
			try
			{
				bool flag = target.Length <= 0 || address.ToInt64() <= 0L || target.Length >= int.MaxValue / Unsafe.SizeOf<T>();
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					Span<byte> span = MemoryMarshal.Cast<T, byte>(target);
					bool flag3 = span.Length > 10000000 && this._enableLogging.Value.Value;
					if (flag3)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Reading ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(span.Length);
						defaultInterpolatedStringHandler.AppendLiteral(" bytes at stack ");
						defaultInterpolatedStringHandler.AppendFormatted<StackTrace>(new StackTrace());
						DebugWindow.LogMsg(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					flag2 = this.Backend.TryReadMemory(address, span);
				}
			}
			catch (Exception ex)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Readmem-> A: ");
				defaultInterpolatedStringHandler.AppendFormatted<IntPtr>(address);
				defaultInterpolatedStringHandler.AppendLiteral(" Size: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(target.Length);
				defaultInterpolatedStringHandler.AppendLiteral(". ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				DebugWindow.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				throw;
			}
			return flag2;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x001A582C File Offset: 0x001A582C
		public byte[] ReadBytes(long addr, int size)
		{
			/*
An exception occurred when decompiling this method (06000495)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] ExileCore2.Memory::ReadBytes(System.Int64,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x001A5848 File Offset: 0x001A5848
		public byte[] ReadBytes(long addr, long size)
		{
			/*
An exception occurred when decompiling this method (06000496)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] ExileCore2.Memory::ReadBytes(System.Int64,System.Int64)

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x001A5864 File Offset: 0x001A5864
		public List<T> ReadStructsArray<T>(long startAddress, long endAddress, int structSize, RemoteMemoryObject game) where T : RemoteMemoryObject, new()
		{
			/*
An exception occurred when decompiling this method (06000497)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<T> ExileCore2.Memory::ReadStructsArray<T>(System.Int64,System.Int64,System.Int32,ExileCore2.PoEMemory.RemoteMemoryObject)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x001A5964 File Offset: 0x001A5964
		public List<T> ReadStructsArray<[IsUnmanaged] T>(long startAddress, long endAddress, int structSize) where T : struct, ValueType
		{
			List<T> list = new List<T>();
			int num = 0;
			long num2 = (endAddress - startAddress) / (long)structSize;
			bool flag = num2 < 0L || num2 > (long)Limits.ReadStructsArrayCount;
			List<T> list2;
			if (flag)
			{
				DebugWindow.LogError("Maybe overflow memory in ReadStructsArray for reading structures of type: " + typeof(T).Name);
				list2 = list;
			}
			else
			{
				for (long num3 = startAddress; num3 < endAddress; num3 += (long)structSize)
				{
					list.Add(this.Read<T>(num3));
					num++;
					bool flag2 = num > Limits.ReadStructsArrayCount;
					if (flag2)
					{
						DebugWindow.LogError("Maybe overflow memory in ReadStructsArray for reading structures of type: " + typeof(T).Name);
						return list;
					}
				}
				list2 = list;
			}
			return list2;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x001A5A24 File Offset: 0x001A5A24
		public IList<T> ReadDoublePtrVectorClasses<T>(long address, RemoteMemoryObject game, bool noNullPointers = false) where T : RemoteMemoryObject, new()
		{
			/*
An exception occurred when decompiling this method (06000499)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<T> ExileCore2.Memory::ReadDoublePtrVectorClasses<T>(System.Int64,ExileCore2.PoEMemory.RemoteMemoryObject,System.Boolean)

 ---> System.Exception: Inconsistent stack size at IL_0015
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x001A5B0C File Offset: 0x001A5B0C
		public IList<long> ReadPointersArray(long startAddress, long endAddress, int offset = 8)
		{
			/*
An exception occurred when decompiling this method (0600049A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Int64> ExileCore2.Memory::ReadPointersArray(System.Int64,System.Int64,System.Int32)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x001A5BF4 File Offset: 0x001A5BF4
		public IList<long> ReadSecondPointerArray_Count(long startAddress, int count)
		{
			/*
An exception occurred when decompiling this method (0600049B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Int64> ExileCore2.Memory::ReadSecondPointerArray_Count(System.Int64,System.Int32)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x001A5BFC File Offset: 0x001A5BFC
		public T Read<[IsUnmanaged] T>(Pointer addr, params int[] offsets) where T : struct, ValueType
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x001A5C04 File Offset: 0x001A5C04
		public T Read<[IsUnmanaged] T>(IntPtr addr, params int[] offsets) where T : struct, ValueType
		{
			bool flag = addr == IntPtr.Zero;
			T t;
			if (flag)
			{
				t = default(T);
			}
			else
			{
				long num = this.Read<long>(addr);
				long num2 = num;
				for (int i = 0; i < offsets.Length - 1; i++)
				{
					bool flag2 = num2 == 0L;
					if (flag2)
					{
						return default(T);
					}
					int num3 = offsets[i];
					num2 = this.Read<long>(num2 + (long)num3);
				}
				t = ((num2 == 0L) ? default(T) : this.Read<T>(num2 + (long)offsets[offsets.Length - 1]));
			}
			return t;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x001A5CA0 File Offset: 0x001A5CA0
		public T Read<[IsUnmanaged] T>(long addr, params int[] offsets) where T : struct, ValueType
		{
			return this.Read<T>(new IntPtr(addr), offsets);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x001A5CC0 File Offset: 0x001A5CC0
		public T Read<[IsUnmanaged] T>(Pointer addr) where T : struct, ValueType
		{
			throw new NotImplementedException();
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x001A5CC8 File Offset: 0x001A5CC8
		public unsafe T Read<[IsUnmanaged] T>(IntPtr addr) where T : struct, ValueType
		{
			bool flag = addr == IntPtr.Zero;
			checked
			{
				T t;
				if (flag)
				{
					t = default(T);
				}
				else
				{
					Span<T> span = new Span<T>(stackalloc byte[unchecked((UIntPtr)1) * (UIntPtr)sizeof(T)], 1);
					Span<T> span2 = span;
					Span<byte> span3 = MemoryMarshal.Cast<T, byte>(span2);
					bool flag2 = span3.Length > 10000000 && this._enableLogging.Value.Value;
					if (flag2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Reading ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(span3.Length);
						defaultInterpolatedStringHandler.AppendLiteral(" bytes at stack ");
						defaultInterpolatedStringHandler.AppendFormatted<StackTrace>(new StackTrace());
						DebugWindow.LogMsg(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					this.Backend.TryReadMemory(addr, span3);
					t = *span2[0];
				}
				return t;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x001A5DA8 File Offset: 0x001A5DA8
		public T Read<[IsUnmanaged] T>(long addr) where T : struct, ValueType
		{
			IntPtr intPtr = new IntPtr(addr);
			return this.Read<T>(intPtr);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x001A5DCC File Offset: 0x001A5DCC
		public IList<Tuple<long, int>> ReadDoublePointerIntList(long address)
		{
			/*
An exception occurred when decompiling this method (060004A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Tuple`2<System.Int64,System.Int32>> ExileCore2.Memory::ReadDoublePointerIntList(System.Int64)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x001A5ED0 File Offset: 0x001A5ED0
		public IList<T> ReadList<[IsUnmanaged] T>(IntPtr head) where T : struct, ValueType
		{
			List<T> list = new List<T>();
			NativeListNode nativeListNode = this.Read<NativeListNode>(head);
			Stopwatch stopwatch = Stopwatch.StartNew();
			long num = head.ToInt64();
			while (num != nativeListNode.Next)
			{
				bool flag = stopwatch.ElapsedMilliseconds > (long)Limits.ReadMemoryTimeLimit;
				if (flag)
				{
					ILogger logger = Core.Logger;
					if (logger != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Readlist error result count: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
						logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					return new List<T>();
				}
				list.Add(this.Read<T>(nativeListNode.Next));
				nativeListNode = this.Read<NativeListNode>(nativeListNode.Next);
			}
			return list;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x001A5F98 File Offset: 0x001A5F98
		public IList<T> ReadStdList<[IsUnmanaged] T>(IntPtr head) where T : struct, ValueType
		{
			List<T> list = new List<T>();
			StdListNode<T> stdListNode;
			for (IntPtr intPtr = this.Read<StdListNode>(head).Next; intPtr != head; intPtr = stdListNode.Next)
			{
				stdListNode = this.Read<StdListNode<T>>(intPtr);
				bool flag = intPtr == IntPtr.Zero;
				if (flag)
				{
					ILogger logger = Core.Logger;
					if (logger != null)
					{
						logger.Error("Terminating reading of list next nodes because of unexpected 0x00 found. This is normal if it happens after closing the game, otherwise report it.");
					}
					break;
				}
				list.Add(stdListNode.Data);
			}
			return list;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x001A6014 File Offset: 0x001A6014
		public List<T> ReadRMOUnorderedMap<T>(UnorderedMap map) where T : RemoteMemoryObject, new()
		{
			/*
An exception occurred when decompiling this method (060004A5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<T> ExileCore2.Memory::ReadRMOUnorderedMap<T>(GameOffsets2.Native.UnorderedMap)

 ---> System.Exception: Inconsistent stack size at IL_000F
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x001A6104 File Offset: 0x001A6104
		public T[] ReadRMOStdVector<T>(StdVector nativeContainer, int objectSize) where T : RemoteMemoryObject, new()
		{
			/*
An exception occurred when decompiling this method (060004A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T[] ExileCore2.Memory::ReadRMOStdVector<T>(GameOffsets2.Native.StdVector,System.Int32)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x001A6198 File Offset: 0x001A6198
		public T[] ReadStdVector<[IsUnmanaged] T>(StdVector nativeContainer) where T : struct, ValueType
		{
			int num = Unsafe.SizeOf<T>();
			long num2 = nativeContainer.Last - nativeContainer.First;
			long num3 = num2 / (long)num;
			bool flag = num2 <= 0L || num2 % (long)num != 0L || num3 > (long)Limits.ReadStructsArrayCount;
			T[] array;
			if (flag)
			{
				array = Array.Empty<T>();
			}
			else
			{
				array = this.ReadMem<T>(nativeContainer.First, (int)num3);
			}
			return array;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x001A61F8 File Offset: 0x001A61F8
		public unsafe T[] ReadStdVectorStride<[IsUnmanaged] T>(StdVector nativeContainer, int stride) where T : struct, ValueType
		{
			int num = Unsafe.SizeOf<T>();
			bool flag = stride < num;
			T[] array;
			if (flag)
			{
				array = Array.Empty<T>();
			}
			else
			{
				long num2 = nativeContainer.Last - nativeContainer.First;
				long num3 = nativeContainer.TotalElements(stride);
				bool flag2 = num2 <= 0L || num2 % (long)stride != 0L || num3 > (long)Array.MaxLength;
				if (flag2)
				{
					array = Array.Empty<T>();
				}
				else
				{
					byte[] array2 = this.ReadBytes(nativeContainer.First, num3 * (long)stride);
					T[] array3 = new T[num3];
					int num4 = 0;
					while ((long)num4 < num3)
					{
						ref byte ptr = ref array2[stride * num4];
						array3[num4] = *Unsafe.As<byte, T>(ref ptr);
						num4++;
					}
					array = array3;
				}
			}
			return array;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x001A62C0 File Offset: 0x001A62C0
		public T[] ReadStdVector<[IsUnmanaged] T>(NativePtrArray nativeContainer) where T : struct, ValueType
		{
			int num = Unsafe.SizeOf<T>();
			long num2 = nativeContainer.Last - nativeContainer.First;
			long num3 = nativeContainer.ElementCount(num);
			bool flag = num2 <= 0L || num2 % (long)num != 0L || num3 > (long)Array.MaxLength;
			T[] array;
			if (flag)
			{
				array = Array.Empty<T>();
			}
			else
			{
				array = this.ReadMem<T>(nativeContainer.First, (int)num3);
			}
			return array;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x001A6324 File Offset: 0x001A6324
		public T[] ReadStdVectorStride<[IsUnmanaged] T>(NativePtrArray nativeContainer, int stride) where T : struct, ValueType
		{
			return this.ReadStdVectorStride<T>(new StdVector
			{
				First = nativeContainer.First,
				End = nativeContainer.End,
				Last = nativeContainer.Last
			}, stride);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x001A6370 File Offset: 0x001A6370
		public T ReadStdVectorElement<[IsUnmanaged] T>(StdVector nativeContainer, int index) where T : struct, ValueType
		{
			int num = Unsafe.SizeOf<T>();
			int num2 = (int)(nativeContainer.Last - nativeContainer.First);
			int num3 = num2 / num;
			bool flag = index < 0 && index >= num3;
			T t;
			if (flag)
			{
				t = default(T);
			}
			else
			{
				t = this.Read<T>(nativeContainer.First + (long)(num * index));
			}
			return t;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x001A63D0 File Offset: 0x001A63D0
		public T ReadStdVectorElement<[IsUnmanaged] T>(NativePtrArray nativeContainer, int index) where T : struct, ValueType
		{
			int num = Unsafe.SizeOf<T>();
			long num2 = nativeContainer.ElementCount(num);
			bool flag = index < 0 && (long)index >= num2;
			T t;
			if (flag)
			{
				t = default(T);
			}
			else
			{
				t = this.Read<T>(nativeContainer.First + (long)(num * index));
			}
			return t;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x001A6428 File Offset: 0x001A6428
		public IList<long> ReadListPointer(IntPtr head)
		{
			/*
An exception occurred when decompiling this method (060004AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.Int64> ExileCore2.Memory::ReadListPointer(System.IntPtr)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x001A64E8 File Offset: 0x001A64E8
		public long[] FindPatterns(params IPattern[] patterns)
		{
			/*
An exception occurred when decompiling this method (060004AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64[] ExileCore2.Memory::FindPatterns(ExileCore2.Shared.Interfaces.IPattern[])

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 404
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x001A6600 File Offset: 0x001A6600
		public bool IsInvalid()
		{
			/*
An exception occurred when decompiling this method (060004AF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.Memory::IsInvalid()

 ---> System.Exception: Inconsistent stack size at IL_0005
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x001A6628 File Offset: 0x001A6628
		public IList<T> ReadNativeArray<[IsUnmanaged] T>(INativePtrArray ptrArray, int offset = 8) where T : struct, ValueType
		{
			return this.ReadNativeArray<T>(ptrArray.First.ToInt64(), ptrArray.Last.ToInt64(), offset);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x001A6660 File Offset: 0x001A6660
		public IList<T> ReadNativeArray<[IsUnmanaged] T>(long first, long last, int offset = 8) where T : struct, ValueType
		{
			bool flag = first == 0L;
			IList<T> list;
			if (flag)
			{
				list = new List<T>();
			}
			else
			{
				IList<long> list2 = this.ReadPointersArray(first, last, offset);
				list = list2.Select<long, T>(new Func<long, T>(this.Read<T>)).ToList<T>();
			}
			return list;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x001A66A8 File Offset: 0x001A66A8
		public Dictionary<int, bool> ReadPackedFlagsVector(StdVector vector)
		{
			/*
An exception occurred when decompiling this method (060004B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Int32,System.Boolean> ExileCore2.Memory::ReadPackedFlagsVector(GameOffsets2.Native.StdVector)

 ---> System.Exception: Inconsistent stack size at IL_0017
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x001A672C File Offset: 0x001A672C
		public void Dispose()
		{
			/*
An exception occurred when decompiling this method (060004B3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.Memory::Dispose()

 ---> System.Exception: Inconsistent stack size at IL_0010
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x001A6790 File Offset: 0x001A6790
		private static string RTrimNull(string text)
		{
			/*
An exception occurred when decompiling this method (060004B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.Memory::RTrimNull(System.String)

 ---> System.Exception: Inconsistent stack size at IL_0006
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x001A67BC File Offset: 0x001A67BC
		// Note: this type is marked as 'beforefieldinit'.
		static Memory()
		{
			16;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x001A67C8 File Offset: 0x001A67C8
		[CompilerGenerated]
		internal static bool <FindPatterns>g__CompareData|69_0(IPattern pattern, Span<byte> data)
		{
			/*
An exception occurred when decompiling this method (060004B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.Memory::<FindPatterns>g__CompareData|69_0(ExileCore2.Shared.Interfaces.IPattern,System.Span`1<System.Byte>)

 ---> System.Exception: Inconsistent stack size at IL_000A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 464
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 117
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1663
*/;
		}

		// Token: 0x04000228 RID: 552
		private readonly CoreSettings _coreSettings;

		// Token: 0x04000229 RID: 553
		private bool closed;

		// Token: 0x0400022A RID: 554
		private IMemoryBackend _backend;

		// Token: 0x0400022B RID: 555
		private readonly TimeCache<IntPtr> _mainWindowHandleCache;

		// Token: 0x0400022E RID: 558
		private readonly ThreadLocal<Memory.BooleanHolder> _enableLogging;

		// Token: 0x04000232 RID: 562
		private static readonly int UnorderedMapKeyOffset;

		// Token: 0x02000087 RID: 135
		private class BooleanHolder
		{
			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060004B7 RID: 1207 RVA: 0x001A6864 File Offset: 0x001A6864
			// (set) Token: 0x060004B8 RID: 1208 RVA: 0x001A686C File Offset: 0x001A686C
			public bool Value
			{
				[CompilerGenerated]
				get
				{
					return this != null;
				}
				[CompilerGenerated]
				set
				{
					this;
					value;
				}
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x001A6878 File Offset: 0x001A6878
			public BooleanHolder()
			{
				this;
			}
		}

		// Token: 0x02000088 RID: 136
		private class EmptyDisposable : IDisposable
		{
			// Token: 0x060004BA RID: 1210 RVA: 0x001A6884 File Offset: 0x001A6884
			public void Dispose()
			{
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x001A6888 File Offset: 0x001A6888
			public EmptyDisposable()
			{
				this;
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x001A6894 File Offset: 0x001A6894
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyDisposable()
			{
				new Memory.EmptyDisposable();
			}

			// Token: 0x04000234 RID: 564
			public static readonly Memory.EmptyDisposable Instance;
		}

		// Token: 0x02000089 RID: 137
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 9)]
		private struct PackedFlagStore
		{
			// Token: 0x04000235 RID: 565
			[FieldOffset(0)]
			public byte PartialId;

			// Token: 0x04000236 RID: 566
			[FieldOffset(1)]
			public ulong Flags;
		}
	}
}
