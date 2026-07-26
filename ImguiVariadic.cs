using System;
using System.Runtime.InteropServices;
using SharpGen.Runtime;

namespace ExileCore2
{
	// Token: 0x0200007E RID: 126
	public static class ImguiVariadic
	{
		// Token: 0x06000458 RID: 1112
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void igTextWrapped(byte* fmt, __arglist);

		// Token: 0x06000459 RID: 1113 RVA: 0x001A4688 File Offset: 0x001A4688
		public unsafe static void TextWrappedUnformatted(string text)
		{
			ImguiVariadic.igTextWrapped(new ReadOnlySpan<byte>((void*)(&global::<PrivateImplementationDetails>.EE50C235AF5866F1C9006029AD5406AB89842BF85D9FF778A70C3F9DA747D15E), 3).GetPointerUnsafe<byte>(), __arglist(text));
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x001A46A4 File Offset: 0x001A46A4
		public unsafe static void TextWrappedUnformatted(string text1, string text2)
		{
			ImguiVariadic.igTextWrapped(new ReadOnlySpan<byte>((void*)(&global::<PrivateImplementationDetails>.DB637963BF086395DC5B4A3369240414184806045C3F6408C7D76F0C43808EB3), 5).GetPointerUnsafe<byte>(), __arglist(text1, text2));
		}
	}
}
