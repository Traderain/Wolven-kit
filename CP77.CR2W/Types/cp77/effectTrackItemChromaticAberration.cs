using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemChromaticAberration : effectTrackItem
	{
		[Ordinal(0)]  [RED("chromaticAberrationExp")] public effectEffectParameterEvaluatorFloat ChromaticAberrationExp { get; set; }
		[Ordinal(1)]  [RED("chromaticAberrationOffset")] public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset { get; set; }
		[Ordinal(2)]  [RED("override")] public CBool Override { get; set; }

		public effectTrackItemChromaticAberration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
