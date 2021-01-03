using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_AxisRange : gameEffectObjectSingleFilter
	{
		[Ordinal(0)]  [RED("axis")] public CEnum<gameEffectObjectFilter_AxisRangeAxis> Axis { get; set; }
		[Ordinal(1)]  [RED("constraints")] public gameEffectInputParameter_Vector Constraints { get; set; }
		[Ordinal(2)]  [RED("position")] public gameEffectInputParameter_Vector Position { get; set; }

		public gameEffectObjectFilter_AxisRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
