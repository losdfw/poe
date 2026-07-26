using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;

namespace ExileCore2.PoEMemory
{
	// Token: 0x020001C9 RID: 457
	public abstract class StructuredRemoteMemoryObject<[IsUnmanaged] T> : RemoteMemoryObject where T : struct, ValueType
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x001C6B18 File Offset: 0x001C6B18
		public StructuredRemoteMemoryObject()
		{
			this._cachedStructValue = base.CreateStructFrameCache<T>();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x001C6B30 File Offset: 0x001C6B30
		public T Structure
		{
			get
			{
				return this._cachedStructValue.Value;
			}
		}

		// Token: 0x040091E7 RID: 37351
		private readonly CachedValue<T> _cachedStructValue;

		// Token: 0x040091E8 RID: 37352
		public static readonly int StructureSize = Unsafe.SizeOf<T>();
	}
}
