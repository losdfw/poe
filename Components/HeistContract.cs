using System;
using ExileCore2.PoEMemory.MemoryObjects.Heist;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200039B RID: 923
	public class HeistContract : Component
	{
		// Token: 0x06001907 RID: 6407 RVA: 0x001E86DC File Offset: 0x001E86DC
		public HeistContract()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x001E8738 File Offset: 0x001E8738
		private HeistContractObjectiveOffsets Objectives
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x001E8748 File Offset: 0x001E8748
		private HeistContractRequirementOffsets Requirements
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x001E8758 File Offset: 0x001E8758
		public BaseItemType TargetItem
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x001E877C File Offset: 0x001E877C
		public string Client
		{
			get
			{
				this;
				this;
				return 1;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x001E879C File Offset: 0x001E879C
		public HeistJobRecord RequiredJob
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x001E87C0 File Offset: 0x001E87C0
		public byte RequiredJobLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04009695 RID: 38549
		private readonly CachedValue<HeistContractComponentOffsets> _ContractData;

		// Token: 0x04009696 RID: 38550
		private readonly CachedValue<HeistContractObjectiveOffsets> _ObjectivesData;

		// Token: 0x04009697 RID: 38551
		private readonly CachedValue<HeistContractRequirementOffsets> _RequirementData;
	}
}
