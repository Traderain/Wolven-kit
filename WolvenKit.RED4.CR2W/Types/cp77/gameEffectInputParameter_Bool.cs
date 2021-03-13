using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Bool : CVariable
	{
		[Ordinal(0)] [RED("evaluator")] public CHandle<gameIEffectParameter_BoolEvaluator> Evaluator { get; set; }

		public gameEffectInputParameter_Bool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
