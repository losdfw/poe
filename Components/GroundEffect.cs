using System;
using ExileCore2.PoEMemory.FilesInMemory;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000393 RID: 915
	public class GroundEffect : Component
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x001E80EC File Offset: 0x001E80EC
		public int SizeIncreaseOverTime
		{
			get
			{
				this;
				return this + 44L;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x001E8104 File Offset: 0x001E8104
		public int Scale
		{
			get
			{
				this;
				return this + 72L;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x001E811C File Offset: 0x001E811C
		public float MaxDuration
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x001E8134 File Offset: 0x001E8134
		public float Duration
		{
			get
			{
				this;
				return this + 52L;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x001E814C File Offset: 0x001E814C
		public GroundEffectDat EffectDescription
		{
			get
			{
				this;
				return this + 56L;
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x001E8178 File Offset: 0x001E8178
		public GroundEffect()
		{
			this;
		}
	}
}
