using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003AF RID: 943
	public class NPC : Component
	{
		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x001E9A18 File Offset: 0x001E9A18
		public bool HasIconOverhead
		{
			get
			{
				this;
				return this + 72L != 0L;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x001E9A34 File Offset: 0x001E9A34
		public bool IsIgnoreHidden
		{
			get
			{
				this;
				return this + 32L == 1;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x001E9A50 File Offset: 0x001E9A50
		public bool IsMinMapLabelVisible
		{
			get
			{
				this;
				return this + 33L == 1;
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x001E9A6C File Offset: 0x001E9A6C
		public NPC()
		{
			this;
		}
	}
}
