using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003EE RID: 1006
internal sealed class <>z__ReadOnlySingleElementList<T> : IEnumerable, ICollection, IList, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
	// Token: 0x06001A9C RID: 6812 RVA: 0x001EBE84 File Offset: 0x001EBE84
	public <>z__ReadOnlySingleElementList(T item)
	{
		this._item = item;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x001EBE94 File Offset: 0x001EBE94
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x17000A54 RID: 2644
	// (get) Token: 0x06001A9E RID: 6814 RVA: 0x001EBEA4 File Offset: 0x001EBEA4
	int ICollection.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A55 RID: 2645
	// (get) Token: 0x06001A9F RID: 6815 RVA: 0x001EBEA8 File Offset: 0x001EBEA8
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000A56 RID: 2646
	// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x001EBEAC File Offset: 0x001EBEAC
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x001EBEB0 File Offset: 0x001EBEB0
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		array.SetValue(this._item, index);
	}

	// Token: 0x17000A57 RID: 2647
	object IList.this[int index]
	{
		[return: Nullable(2)]
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
		[param: Nullable(2)]
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000A58 RID: 2648
	// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x001EBEE8 File Offset: 0x001EBEE8
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000A59 RID: 2649
	// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x001EBEEC File Offset: 0x001EBEEC
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x001EBEF0 File Offset: 0x001EBEF0
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x001EBEF8 File Offset: 0x001EBEF8
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x001EBF00 File Offset: 0x001EBF00
	bool IList.Contains([Nullable(2)] object value)
	{
		return EqualityComparer<T>.Default.Equals(this._item, (T)((object)value));
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x001EBF18 File Offset: 0x001EBF18
	int IList.IndexOf([Nullable(2)] object value)
	{
		return EqualityComparer<T>.Default.Equals(this._item, (T)((object)value)) ? 0 : (-1);
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x001EBF38 File Offset: 0x001EBF38
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x001EBF40 File Offset: 0x001EBF40
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x001EBF48 File Offset: 0x001EBF48
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x001EBF50 File Offset: 0x001EBF50
	[return: Nullable(new byte[] { 1, 0 })]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x17000A5A RID: 2650
	// (get) Token: 0x06001AAE RID: 6830 RVA: 0x001EBF60 File Offset: 0x001EBF60
	int IReadOnlyCollection<T>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A5B RID: 2651
	T IReadOnlyList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
	}

	// Token: 0x17000A5C RID: 2652
	// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x001EBF78 File Offset: 0x001EBF78
	int ICollection<T>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17000A5D RID: 2653
	// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x001EBF7C File Offset: 0x001EBF7C
	bool ICollection<T>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x001EBF80 File Offset: 0x001EBF80
	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x001EBF88 File Offset: 0x001EBF88
	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x001EBF90 File Offset: 0x001EBF90
	bool ICollection<T>.Contains(T item)
	{
		return EqualityComparer<T>.Default.Equals(this._item, item);
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x001EBFA4 File Offset: 0x001EBFA4
	void ICollection<T>.CopyTo([Nullable(new byte[] { 1, 0 })] T[] array, int arrayIndex)
	{
		array[arrayIndex] = this._item;
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x001EBFB4 File Offset: 0x001EBFB4
	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17000A5E RID: 2654
	T IList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x001EBFD8 File Offset: 0x001EBFD8
	int IList<T>.IndexOf(T item)
	{
		return EqualityComparer<T>.Default.Equals(this._item, item) ? 0 : (-1);
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x001EBFF4 File Offset: 0x001EBFF4
	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x001EBFFC File Offset: 0x001EBFFC
	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040096FD RID: 38653
	[CompilerGenerated]
	private readonly T _item;

	// Token: 0x020003EF RID: 1007
	private sealed class Enumerator : IDisposable, IEnumerator, IEnumerator<T>
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x001EC004 File Offset: 0x001EC004
		public Enumerator(T item)
		{
			this.System.Collections.Generic.IEnumerator<T>.Current = item;
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x001EC014 File Offset: 0x001EC014
		object IEnumerator.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x001EC024 File Offset: 0x001EC024
		T IEnumerator<T>.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x001EC02C File Offset: 0x001EC02C
		bool IEnumerator.MoveNext()
		{
			return !this._moveNextCalled && (this._moveNextCalled = true);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x001EC050 File Offset: 0x001EC050
		void IEnumerator.Reset()
		{
			this._moveNextCalled = false;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x001EC05C File Offset: 0x001EC05C
		void IDisposable.Dispose()
		{
		}

		// Token: 0x040096FE RID: 38654
		[CompilerGenerated]
		private readonly T _item;

		// Token: 0x040096FF RID: 38655
		[CompilerGenerated]
		private bool _moveNextCalled;
	}
}
