using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003ED RID: 1005
internal sealed class <>z__ReadOnlyArray<T> : IEnumerable, ICollection, IList, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
	// Token: 0x06001A7C RID: 6780 RVA: 0x001EBD28 File Offset: 0x001EBD28
	public <>z__ReadOnlyArray(T[] items)
	{
		this._items = items;
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x001EBD38 File Offset: 0x001EBD38
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x17000A49 RID: 2633
	// (get) Token: 0x06001A7E RID: 6782 RVA: 0x001EBD48 File Offset: 0x001EBD48
	int ICollection.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17000A4A RID: 2634
	// (get) Token: 0x06001A7F RID: 6783 RVA: 0x001EBD54 File Offset: 0x001EBD54
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000A4B RID: 2635
	// (get) Token: 0x06001A80 RID: 6784 RVA: 0x001EBD58 File Offset: 0x001EBD58
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x001EBD5C File Offset: 0x001EBD5C
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		this._items.CopyTo(array, index);
	}

	// Token: 0x17000A4C RID: 2636
	object IList.this[int index]
	{
		[return: Nullable(2)]
		get
		{
			return this._items[index];
		}
		[param: Nullable(2)]
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000A4D RID: 2637
	// (get) Token: 0x06001A84 RID: 6788 RVA: 0x001EBD88 File Offset: 0x001EBD88
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000A4E RID: 2638
	// (get) Token: 0x06001A85 RID: 6789 RVA: 0x001EBD8C File Offset: 0x001EBD8C
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x001EBD90 File Offset: 0x001EBD90
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x001EBD98 File Offset: 0x001EBD98
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x001EBDA0 File Offset: 0x001EBDA0
	bool IList.Contains([Nullable(2)] object value)
	{
		return this._items.Contains(value);
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x001EBDB0 File Offset: 0x001EBDB0
	int IList.IndexOf([Nullable(2)] object value)
	{
		return this._items.IndexOf(value);
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x001EBDC0 File Offset: 0x001EBDC0
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x001EBDC8 File Offset: 0x001EBDC8
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A8C RID: 6796 RVA: 0x001EBDD0 File Offset: 0x001EBDD0
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x001EBDD8 File Offset: 0x001EBDD8
	[return: Nullable(new byte[] { 1, 0 })]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x17000A4F RID: 2639
	// (get) Token: 0x06001A8E RID: 6798 RVA: 0x001EBDE8 File Offset: 0x001EBDE8
	int IReadOnlyCollection<T>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17000A50 RID: 2640
	T IReadOnlyList<T>.this[int index]
	{
		get
		{
			return this._items[index];
		}
	}

	// Token: 0x17000A51 RID: 2641
	// (get) Token: 0x06001A90 RID: 6800 RVA: 0x001EBE04 File Offset: 0x001EBE04
	int ICollection<T>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17000A52 RID: 2642
	// (get) Token: 0x06001A91 RID: 6801 RVA: 0x001EBE10 File Offset: 0x001EBE10
	bool ICollection<T>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x001EBE14 File Offset: 0x001EBE14
	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x001EBE1C File Offset: 0x001EBE1C
	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x001EBE24 File Offset: 0x001EBE24
	bool ICollection<T>.Contains(T item)
	{
		return this._items.Contains(item);
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x001EBE34 File Offset: 0x001EBE34
	void ICollection<T>.CopyTo([Nullable(new byte[] { 1, 0 })] T[] array, int arrayIndex)
	{
		this._items.CopyTo(array, arrayIndex);
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x001EBE44 File Offset: 0x001EBE44
	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17000A53 RID: 2643
	T IList<T>.this[int index]
	{
		get
		{
			return this._items[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x001EBE64 File Offset: 0x001EBE64
	int IList<T>.IndexOf(T item)
	{
		return this._items.IndexOf(item);
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x001EBE74 File Offset: 0x001EBE74
	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x001EBE7C File Offset: 0x001EBE7C
	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040096FC RID: 38652
	[CompilerGenerated]
	private readonly T[] _items;
}
