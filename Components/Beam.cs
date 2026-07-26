using System;
using System.Numerics;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000380 RID: 896
	public class Beam : Component
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x001E739C File Offset: 0x001E739C
		public Vector3 BeamStart
		{
			get
			{
				this;
				return this + 80L;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x001E73B4 File Offset: 0x001E73B4
		public Vector3 BeamEnd
		{
			get
			{
				this;
				return this + 92L;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x001E73CC File Offset: 0x001E73CC
		public int Unknown1
		{
			get
			{
				this;
				return this + 64L;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x001E73E4 File Offset: 0x001E73E4
		public int Unknown2
		{
			get
			{
				this;
				return this + 68L;
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x001E73FC File Offset: 0x001E73FC
		public Beam()
		{
			this;
		}
	}
}
