using System;
using ExileCore2.PoEMemory.MemoryObjects.Archive;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003BB RID: 955
	public class Prophecy : Component
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x001EA7EC File Offset: 0x001EA7EC
		public ProphecyDat DatProphecy
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x001EA818 File Offset: 0x001EA818
		public Prophecy()
		{
			this;
		}
	}
}
