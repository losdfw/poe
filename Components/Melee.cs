using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.FilesInMemory.Animations;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x020003A7 RID: 935
	public class Melee : Component
	{
		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x001E9250 File Offset: 0x001E9250
		public bool HasHitProcessors
		{
			get
			{
				Melee melee = this + this;
				while ((melee = melee) != null)
				{
				}
				return this != null;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x001E92A4 File Offset: 0x001E92A4
		public float RawMeleeAnimationProgress
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x001E92C0 File Offset: 0x001E92C0
		public List<AnimationMeleeDamagePattern> Patterns
		{
			get
			{
				this;
				this + this;
				return new int[1];
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x001E92F8 File Offset: 0x001E92F8
		public Melee()
		{
			this;
		}
	}
}
