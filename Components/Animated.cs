using System;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200036E RID: 878
	public class Animated : Component
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x001E63A8 File Offset: 0x001E63A8
		public Animated()
		{
			this;
			this;
			this;
			this;
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x001E63D8 File Offset: 0x001E63D8
		public Entity BaseAnimatedObjectEntity
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x001E63E8 File Offset: 0x001E63E8
		public MiscAnimatedDat MiscAnimated
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04009661 RID: 38497
		private readonly CachedValue<Entity> _baseAnimatedObjectEntityCache;
	}
}
