using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetControllerStimSource : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("investigateData")] public stimInvestigateData InvestigateData { get; set; }

		public SetControllerStimSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
