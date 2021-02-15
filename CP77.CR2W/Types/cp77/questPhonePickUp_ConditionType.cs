using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhonePickUp_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
		[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }

		public questPhonePickUp_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
