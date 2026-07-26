using System;

namespace ExileCore2
{
	// Token: 0x02000073 RID: 115
	public interface IMemoryBackend : IDisposable
	{
		// Token: 0x06000433 RID: 1075
		bool TryReadMemory(IntPtr address, Span<byte> target);

		// Token: 0x06000434 RID: 1076
		void NotifyFrame();
	}
}
