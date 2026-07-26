using System;

namespace ExileCore2
{
	// Token: 0x0200005E RID: 94
	internal class DisposableAction : IDisposable
	{
		// Token: 0x06000315 RID: 789 RVA: 0x0019FA7C File Offset: 0x0019FA7C
		public DisposableAction(Action action)
		{
			this;
			this;
			action;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0019FA90 File Offset: 0x0019FA90
		public void Dispose()
		{
			this;
		}

		// Token: 0x0400017C RID: 380
		private readonly Action _action;
	}
}
