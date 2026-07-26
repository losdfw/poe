using System;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003A6 RID: 934
	public class Map : Component
	{
		// Token: 0x06001957 RID: 6487 RVA: 0x001E91C0 File Offset: 0x001E91C0
		public Map()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x001E91F8 File Offset: 0x001E91F8
		public MapComponentInner MapInformation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x001E9208 File Offset: 0x001E9208
		public byte Tier
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040096A9 RID: 38569
		private readonly Lazy<MapComponentBase> _mapBase;

		// Token: 0x040096AA RID: 38570
		private readonly Lazy<MapComponentInner> _mapInner;
	}
}
