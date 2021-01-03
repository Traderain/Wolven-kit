using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Cover : animAnimFeature
	{
		[Ordinal(0)]  [RED("behavior")] public CInt32 Behavior { get; set; }
		[Ordinal(1)]  [RED("behaviorTime_Action")] public CFloat BehaviorTime_Action { get; set; }
		[Ordinal(2)]  [RED("behaviorTime_PostAction")] public CFloat BehaviorTime_PostAction { get; set; }
		[Ordinal(3)]  [RED("behaviorTime_PreAction")] public CFloat BehaviorTime_PreAction { get; set; }
		[Ordinal(4)]  [RED("coverAction")] public CInt32 CoverAction { get; set; }
		[Ordinal(5)]  [RED("coverAngleToAction")] public CFloat CoverAngleToAction { get; set; }
		[Ordinal(6)]  [RED("coverDirection")] public Vector4 CoverDirection { get; set; }
		[Ordinal(7)]  [RED("coverPosition")] public Vector4 CoverPosition { get; set; }
		[Ordinal(8)]  [RED("coverState")] public CInt32 CoverState { get; set; }
		[Ordinal(9)]  [RED("stance")] public CInt32 Stance { get; set; }

		public animAnimFeature_Cover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
