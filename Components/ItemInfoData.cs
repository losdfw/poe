using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.FilesInMemory;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200037E RID: 894
	public class ItemInfoData : RemoteMemoryObject
	{
		// Token: 0x0600186C RID: 6252 RVA: 0x001E70A0 File Offset: 0x001E70A0
		public ItemInfoData()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x001E70C4 File Offset: 0x001E70C4
		internal t27869 ItemInfoDataStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x001E70D4 File Offset: 0x001E70D4
		public byte ItemCellsSizeX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x001E70E4 File Offset: 0x001E70E4
		public byte ItemCellsSizeY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x001E70F4 File Offset: 0x001E70F4
		public string Name
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x001E710C File Offset: 0x001E710C
		public BaseItemType BaseItemTypeDat
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x001E7130 File Offset: 0x001E7130
		public List<TagsDat.TagRecord> TagsDat
		{
			get
			{
				this;
				this;
				return 16;
			}
		}

		// Token: 0x04009678 RID: 38520
		private readonly CachedValue<t27869> _cachedValue;
	}
}
