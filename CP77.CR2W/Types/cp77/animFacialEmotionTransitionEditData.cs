using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFacialEmotionTransitionEditData : CVariable
	{
		[Ordinal(0)]  [RED("customTransitionAnim")] public CName CustomTransitionAnim { get; set; }
		[Ordinal(1)]  [RED("facialKeyFemale")] public CName FacialKeyFemale { get; set; }
		[Ordinal(2)]  [RED("facialKeyMale")] public CName FacialKeyMale { get; set; }
		[Ordinal(3)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(4)]  [RED("toIdleFemale")] public CName ToIdleFemale { get; set; }
		[Ordinal(5)]  [RED("toIdleMale")] public CName ToIdleMale { get; set; }
		[Ordinal(6)]  [RED("toIdleNeckWeight")] public CFloat ToIdleNeckWeight { get; set; }
		[Ordinal(7)]  [RED("toIdleWeight")] public CFloat ToIdleWeight { get; set; }
		[Ordinal(8)]  [RED("transitionType")] public CEnum<animFacialEmotionTransitionType> TransitionType { get; set; }

		public animFacialEmotionTransitionEditData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
