using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckItemLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("NameRef")] public inkTextWidgetReference NameRef { get; set; }
		[Ordinal(1)]  [RED("ConditionDataListRef")] public inkCompoundWidgetReference ConditionDataListRef { get; set; }
		[Ordinal(2)]  [RED("ConditionDataItems")] public CArray<wCHandle<inkWidget>> ConditionDataItems { get; set; }
		[Ordinal(3)]  [RED("ConditionDataItemName")] public CName ConditionDataItemName { get; set; }
		[Ordinal(4)]  [RED("PassedStateName")] public CName PassedStateName { get; set; }
		[Ordinal(5)]  [RED("FailedStateName")] public CName FailedStateName { get; set; }

		public ScannerSkillCheckItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
