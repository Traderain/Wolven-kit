using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingNotificationEvent : redEvent
	{
		[Ordinal(0)]  [RED("notificationType")] public CEnum<CraftingNotificationType> NotificationType { get; set; }
		[Ordinal(1)]  [RED("perkName")] public CString PerkName { get; set; }

		public CraftingNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
