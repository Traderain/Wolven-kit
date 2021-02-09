using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(1)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)]  [RED("avatarImage")] public inkImageWidgetReference AvatarImage { get; set; }
		[Ordinal(3)]  [RED("menuBackgrouns")] public inkWidgetReference MenuBackgrouns { get; set; }
		[Ordinal(4)]  [RED("hintTrack")] public inkWidgetReference HintTrack { get; set; }
		[Ordinal(5)]  [RED("hintClose")] public inkWidgetReference HintClose { get; set; }
		[Ordinal(6)]  [RED("hintReply")] public inkWidgetReference HintReply { get; set; }
		[Ordinal(7)]  [RED("hintMessenger")] public inkWidgetReference HintMessenger { get; set; }
		[Ordinal(8)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(9)]  [RED("blackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(10)]  [RED("uiSystem")] public CHandle<gameuiGameSystemUI> UiSystem { get; set; }
		[Ordinal(11)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(12)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(13)]  [RED("data")] public CHandle<JournalNotificationData> Data { get; set; }
		[Ordinal(14)]  [RED("entry")] public wCHandle<gameJournalPhoneMessage> Entry { get; set; }
		[Ordinal(15)]  [RED("contactEntry")] public wCHandle<gameJournalContact> ContactEntry { get; set; }
		[Ordinal(16)]  [RED("attachment")] public wCHandle<gameJournalEntry> Attachment { get; set; }
		[Ordinal(17)]  [RED("attachmentHash")] public CUInt32 AttachmentHash { get; set; }
		[Ordinal(18)]  [RED("activeEntry")] public wCHandle<gameJournalEntry> ActiveEntry { get; set; }
		[Ordinal(19)]  [RED("dialogViewController")] public wCHandle<MessengerDialogViewController> DialogViewController { get; set; }
		[Ordinal(20)]  [RED("proxy")] public CHandle<inkanimProxy> Proxy { get; set; }

		public PhoneMessagePopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
