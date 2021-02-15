using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStatsCondition : questTypedCondition
	{
		[Ordinal(0)] [RED("type")] public CHandle<questIStatsConditionType> Type { get; set; }

		public questStatsCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
