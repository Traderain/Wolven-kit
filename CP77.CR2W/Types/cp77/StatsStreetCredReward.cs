using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsStreetCredReward : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("prevRewardsList")] public inkCompoundWidgetReference PrevRewardsList { get; set; }
		[Ordinal(1)]  [RED("currentRewardsList")] public inkCompoundWidgetReference CurrentRewardsList { get; set; }
		[Ordinal(2)]  [RED("nextRewardsList")] public inkCompoundWidgetReference NextRewardsList { get; set; }
		[Ordinal(3)]  [RED("scrollSlider")] public inkCompoundWidgetReference ScrollSlider { get; set; }
		[Ordinal(4)]  [RED("scrollButtonHint")] public inkCompoundWidgetReference ScrollButtonHint { get; set; }
		[Ordinal(5)]  [RED("rewardSize")] public CInt32 RewardSize { get; set; }
		[Ordinal(6)]  [RED("tooltipIndex")] public CInt32 TooltipIndex { get; set; }
		[Ordinal(7)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public StatsStreetCredReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
