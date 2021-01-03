using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : CVariable
	{
		[Ordinal(0)]  [RED("gridDivisionsCount")] public CUInt32 GridDivisionsCount { get; set; }
		[Ordinal(1)]  [RED("maxValue")] public CFloat MaxValue { get; set; }
		[Ordinal(2)]  [RED("minValue")] public CFloat MinValue { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }

		public animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
