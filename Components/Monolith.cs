using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003AC RID: 940
	public class Monolith : Component
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x001E9988 File Offset: 0x001E9988
		public int OpenStage
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x001E99A4 File Offset: 0x001E99A4
		public bool IsOpened
		{
			get
			{
				return this == 4;
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x001E99B0 File Offset: 0x001E99B0
		public Monolith()
		{
			this;
		}
	}
}
