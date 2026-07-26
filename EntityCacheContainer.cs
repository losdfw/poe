using System;
using System.Collections.Concurrent;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2
{
	// Token: 0x02000060 RID: 96
	public class EntityCacheContainer
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0019FB50 File Offset: 0x0019FB50
		public EntityCacheContainer()
		{
			this;
			this;
			this;
		}

		// Token: 0x04000185 RID: 389
		public readonly ConcurrentDictionary<uint, Entity> Entities;

		// Token: 0x04000186 RID: 390
		public DateTime LastUsedDate;

		// Token: 0x04000187 RID: 391
		public int InstanceId;
	}
}
