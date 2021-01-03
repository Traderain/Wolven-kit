using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class STonemappingACESParams : CVariable
	{
		[Ordinal(0)]  [RED("adjustWhitePoint")] public CBool AdjustWhitePoint { get; set; }
		[Ordinal(1)]  [RED("applyAfterLUT")] public CBool ApplyAfterLUT { get; set; }
		[Ordinal(2)]  [RED("desaturate")] public CBool Desaturate { get; set; }
		[Ordinal(3)]  [RED("dimSurround")] public CBool DimSurround { get; set; }
		[Ordinal(4)]  [RED("maxStops")] public CFloat MaxStops { get; set; }
		[Ordinal(5)]  [RED("midGrayScale")] public CFloat MidGrayScale { get; set; }
		[Ordinal(6)]  [RED("minStops")] public CFloat MinStops { get; set; }
		[Ordinal(7)]  [RED("surroundGamma")] public CFloat SurroundGamma { get; set; }
		[Ordinal(8)]  [RED("toneCurveSaturation")] public CFloat ToneCurveSaturation { get; set; }
		[Ordinal(9)]  [RED("tonemapLuminance")] public CBool TonemapLuminance { get; set; }

		public STonemappingACESParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
