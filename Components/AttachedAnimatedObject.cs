using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x0200037B RID: 891
	public class AttachedAnimatedObject : Component
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x001E6FB0 File Offset: 0x001E6FB0
		public List<AttachedAnimatedObjectAttachment> Attachments
		{
			get
			{
				this;
				return this + this;
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x001E6FE0 File Offset: 0x001E6FE0
		public AttachedAnimatedObject()
		{
			this;
		}
	}
}
