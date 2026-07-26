using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003D4 RID: 980
	public class Usable : Component
	{
		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x001EB9F4 File Offset: 0x001EB9F4
		public string UseActionString
		{
			get
			{
				this;
				this + 16L;
				(new int[1])[0] = 24;
				return this;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x001EBA24 File Offset: 0x001EBA24
		public int UseAction
		{
			get
			{
				this;
				this + 16L;
				return new int[] { 16 };
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x001EBA48 File Offset: 0x001EBA48
		public Usable()
		{
			this;
		}
	}
}
