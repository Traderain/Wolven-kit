using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questShowPopup_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)]  [RED("closeAtInput")] public CBool CloseAtInput { get; set; }
		[Ordinal(1)]  [RED("closeCurrentPopup")] public CBool CloseCurrentPopup { get; set; }
		[Ordinal(2)]  [RED("hideInMenu")] public CBool HideInMenu { get; set; }
		[Ordinal(3)]  [RED("ignoreDisabledTutorials")] public CBool IgnoreDisabledTutorials { get; set; }
		[Ordinal(4)]  [RED("lockPlayerMovement")] public CBool LockPlayerMovement { get; set; }
		[Ordinal(5)]  [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(6)]  [RED("open")] public CBool Open { get; set; }
		[Ordinal(7)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(8)]  [RED("pauseGame")] public CBool PauseGame { get; set; }
		[Ordinal(9)]  [RED("position")] public CEnum<gamePopupPosition> Position { get; set; }
		[Ordinal(10)]  [RED("screenMode")] public CEnum<questTutorialScreenMode> ScreenMode { get; set; }
		[Ordinal(11)]  [RED("video")] public raRef<Bink> Video { get; set; }
		[Ordinal(12)]  [RED("videoType")] public CEnum<gameVideoType> VideoType { get; set; }

		public questShowPopup_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
