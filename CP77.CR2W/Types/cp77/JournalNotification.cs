using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalNotification : GenericNotificationController
	{
		[Ordinal(9)]  [RED("interactionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(10)]  [RED("bbListenerId")] public CUInt32 BbListenerId { get; set; }
		[Ordinal(11)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(12)]  [RED("questNotificationData")] public CHandle<gameuiQuestUpdateNotificationViewData> QuestNotificationData { get; set; }

		public JournalNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
