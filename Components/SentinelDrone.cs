using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003C0 RID: 960
	public class SentinelDrone : Component
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x001EAA9C File Offset: 0x001EAA9C
		public int TimesUsed
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x001EAAB4 File Offset: 0x001EAAB4
		public int MaxUses
		{
			get
			{
				this;
				this + 16L;
				return new int[] { 16, 32 };
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x001EAADC File Offset: 0x001EAADC
		public SentinelDrone()
		{
			this;
		}
	}
}
