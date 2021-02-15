using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAvailableExposureMethodResult : CVariable
	{
		[Ordinal(0)] [RED("distanceToTarget")] public CFloat DistanceToTarget { get; set; }
		[Ordinal(1)] [RED("method")] public CEnum<AICoverExposureMethod> Method { get; set; }

		public gameAvailableExposureMethodResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
