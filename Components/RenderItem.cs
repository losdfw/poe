using System;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003BE RID: 958
	public class RenderItem : Component
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x001EAA34 File Offset: 0x001EAA34
		public RenderItem()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x001EAA5C File Offset: 0x001EAA5C
		public string ResourcePath
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040096C0 RID: 38592
		private readonly CachedValue<string> _pathCache;
	}
}
