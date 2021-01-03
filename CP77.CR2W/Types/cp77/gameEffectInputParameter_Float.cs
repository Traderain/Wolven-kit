using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Float : CVariable
	{
		[Ordinal(0)]  [RED("evaluator")] public CHandle<gameIEffectParameter_FloatEvaluator> Evaluator { get; set; }

		public gameEffectInputParameter_Float(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
