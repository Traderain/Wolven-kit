using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PreClimbing : animAnimFeature
	{
		[Ordinal(0)] [RED("edgePositionLS")] public Vector4 EdgePositionLS { get; set; }
		[Ordinal(1)] [RED("valid")] public CFloat Valid { get; set; }

		public AnimFeature_PreClimbing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
