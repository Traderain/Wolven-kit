using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questJournalEntryState_ConditionType : questIJournalConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(2)]  [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }

		public questJournalEntryState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
