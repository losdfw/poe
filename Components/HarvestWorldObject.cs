using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000397 RID: 919
	public class HarvestWorldObject : Component
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x001E82CC File Offset: 0x001E82CC
		public HarvestWorldObject()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x001E82E4 File Offset: 0x001E82E4
		public List<HarvestSeedSpawnDescriptor> Seeds
		{
			get
			{
				this;
				this;
				return 24;
			}
		}

		// Token: 0x04009692 RID: 38546
		private readonly CachedValue<HarvestWorldObjectComponentOffsets> _cacheValue;
	}
}
