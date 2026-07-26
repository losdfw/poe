using System;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003D2 RID: 978
	public class Transitionable : Component
	{
		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x001EB89C File Offset: 0x001EB89C
		public byte Flag1
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x001EB8B8 File Offset: 0x001EB8B8
		public byte Flag2
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x001EB8D4 File Offset: 0x001EB8D4
		public Transitionable()
		{
			this;
		}
	}
}
