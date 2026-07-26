using System;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003CF RID: 975
	public class Targetable : Component
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x001EB7CC File Offset: 0x001EB7CC
		public Targetable()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x001EB7F0 File Offset: 0x001EB7F0
		public TargetableComponentOffsets TargetableComponent
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x001EB800 File Offset: 0x001EB800
		public bool isTargetable
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x001EB810 File Offset: 0x001EB810
		public bool isTargeted
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x040096D8 RID: 38616
		private readonly CachedValue<TargetableComponentOffsets> _cachedValue;
	}
}
