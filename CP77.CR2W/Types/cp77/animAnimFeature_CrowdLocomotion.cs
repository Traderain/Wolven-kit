using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		[Ordinal(0)]  [RED("isCrowd")] public CBool IsCrowd { get; set; }
		[Ordinal(1)]  [RED("slopeAngle")] public CFloat SlopeAngle { get; set; }
		[Ordinal(2)]  [RED("speed")] public CFloat Speed { get; set; }

		public animAnimFeature_CrowdLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
