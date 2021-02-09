using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneHotkeyController : GenericHotkeyController
	{
		[Ordinal(17)]  [RED("mainIcon")] public inkImageWidgetReference MainIcon { get; set; }
		[Ordinal(18)]  [RED("messagePrompt")] public inkTextWidgetReference MessagePrompt { get; set; }
		[Ordinal(19)]  [RED("messageCounter")] public inkTextWidgetReference MessageCounter { get; set; }
		[Ordinal(20)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(21)]  [RED("phoneIconAtlas")] public CString PhoneIconAtlas { get; set; }
		[Ordinal(22)]  [RED("phoneIconName")] public CName PhoneIconName { get; set; }

		public PhoneHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
