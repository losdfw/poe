using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;

namespace ExileCore2
{
	// Token: 0x02000047 RID: 71
	[Submenu]
	public class CorePerformanceSettings
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0019CFE4 File Offset: 0x0019CFE4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0019CFEC File Offset: 0x0019CFEC
		public RangeNode<int> EntityParserThreads
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0019CFF8 File Offset: 0x0019CFF8
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0019D000 File Offset: 0x0019D000
		[Menu("Target FPS")]
		public RangeNode<int> TargetFps
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0019D00C File Offset: 0x0019D00C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0019D014 File Offset: 0x0019D014
		[Menu(null, "How often to update entities. You can see time spent on this in DebugWindow->Coroutines.")]
		public RangeNode<int> EntitiesFps
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0019D020 File Offset: 0x0019D020
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0019D028 File Offset: 0x0019D028
		public ToggleNode ParseServerEntities
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0019D034 File Offset: 0x0019D034
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0019D03C File Offset: 0x0019D03C
		[Menu("Limit draw plot in ms", "Don't put small value, because plot need a lot triangles and DebugWindow with a lot plot will be broke.")]
		public RangeNode<float> LimitDrawPlot
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0019D048 File Offset: 0x0019D048
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0019D050 File Offset: 0x0019D050
		public RangeNode<int> MaxGroundItemLabels
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0019D05C File Offset: 0x0019D05C
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0019D064 File Offset: 0x0019D064
		public RangeNode<int> MaxEntities
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

		// Token: 0x0600022B RID: 555 RVA: 0x0019D070 File Offset: 0x0019D070
		public CorePerformanceSettings()
		{
			this;
			1;
			0;
			this;
			60;
			5;
			this;
			60;
			5;
			this;
			1;
			this;
			this;
			0;
			this;
			0;
			this;
		}
	}
}
