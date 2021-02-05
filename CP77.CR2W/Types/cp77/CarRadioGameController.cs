using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CarRadioGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("radioStationName")] public inkTextWidgetReference RadioStationName { get; set; }
		[Ordinal(8)]  [RED("songName")] public inkTextWidgetReference SongName { get; set; }
		[Ordinal(9)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(10)]  [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }
		[Ordinal(11)]  [RED("songNameChangeBlackboardId")] public CUInt32 SongNameChangeBlackboardId { get; set; }
		[Ordinal(12)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(13)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public CarRadioGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
