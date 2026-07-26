using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001BA RID: 442
	public struct FileInformation
	{
		// Token: 0x06000CBB RID: 3259 RVA: 0x001C59EC File Offset: 0x001C59EC
		public FileInformation(long ptr, int changeCount)
		{
			ref this;
			ptr;
			ref this;
			changeCount;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x001C5A00 File Offset: 0x001C5A00
		public readonly long Ptr
		{
			[CompilerGenerated]
			get
			{
				return ref this;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x001C5A08 File Offset: 0x001C5A08
		public readonly int ChangeCount
		{
			[CompilerGenerated]
			get
			{
				return ref this;
			}
		}
	}
}
