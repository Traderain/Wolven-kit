using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DemolitionContainer : BaseSkillCheckContainer
	{
		[Ordinal(0)]  [RED("hackingCheckSlot")] public CHandle<HackingSkillCheck> HackingCheckSlot { get; set; }
		[Ordinal(1)]  [RED("engineeringCheckSlot")] public CHandle<EngineeringSkillCheck> EngineeringCheckSlot { get; set; }
		[Ordinal(2)]  [RED("demolitionCheckSlot")] public CHandle<DemolitionSkillCheck> DemolitionCheckSlot { get; set; }
		[Ordinal(3)]  [RED("demolitionCheck")] public CHandle<DemolitionSkillCheck> DemolitionCheck { get; set; }

		public DemolitionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
