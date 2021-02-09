using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayConditionContainer : IScriptable
	{
		[Ordinal(0)]  [RED("logicOperator")] public CEnum<ELogicOperator> LogicOperator { get; set; }
		[Ordinal(1)]  [RED("conditionGroups")] public CArray<ConditionGroupData> ConditionGroups { get; set; }

		public GameplayConditionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
