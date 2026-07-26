using System;
using System.Collections.Generic;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200038F RID: 911
	public class EffectPack : Component
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x001E7CDC File Offset: 0x001E7CDC
		private StdVector EffectVector
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060018D3 RID: 6355 RVA: 0x001E7CF4 File Offset: 0x001E7CF4
		private List<long> EffectPtrList
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x001E7D14 File Offset: 0x001E7D14
		private List<EffectPack.Effect> Effects
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x001E7D34 File Offset: 0x001E7D34
		public EffectPack()
		{
			this;
		}

		// Token: 0x02000390 RID: 912
		public class Effect : RemoteMemoryObject
		{
			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x060018D6 RID: 6358 RVA: 0x001E7D40 File Offset: 0x001E7D40
			public string Name
			{
				get
				{
					this;
					this + 8L;
					return this;
				}
			}

			// Token: 0x060018D7 RID: 6359 RVA: 0x001E7D64 File Offset: 0x001E7D64
			public Effect()
			{
				this;
			}
		}
	}
}
