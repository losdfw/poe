using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2
{
	// Token: 0x0200005F RID: 95
	public class EntityCollectSettingsContainer
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0019FAA0 File Offset: 0x0019FAA0
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0019FAA8 File Offset: 0x0019FAA8
		public Stack<Entity> NewEntities
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0019FAB4 File Offset: 0x0019FAB4
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0019FABC File Offset: 0x0019FABC
		public Queue<uint> DeletedEntityIds
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0019FAC8 File Offset: 0x0019FAC8
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0019FAD0 File Offset: 0x0019FAD0
		public Func<long> EntitiesCount
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0019FADC File Offset: 0x0019FADC
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0019FAE4 File Offset: 0x0019FAE4
		public Func<int?> CurrentInstanceId
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0019FAF0 File Offset: 0x0019FAF0
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0019FAF8 File Offset: 0x0019FAF8
		public EntityCacheContainer EntityCache
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0019FB04 File Offset: 0x0019FB04
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0019FB0C File Offset: 0x0019FB0C
		public uint EntitiesVersion
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0019FB18 File Offset: 0x0019FB18
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0019FB20 File Offset: 0x0019FB20
		public bool NeedUpdate
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0019FB2C File Offset: 0x0019FB2C
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0019FB34 File Offset: 0x0019FB34
		public bool Break
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0019FB40 File Offset: 0x0019FB40
		public EntityCollectSettingsContainer()
		{
			this;
			1;
			this;
		}
	}
}
