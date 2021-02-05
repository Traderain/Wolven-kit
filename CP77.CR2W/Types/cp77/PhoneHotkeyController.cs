using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneHotkeyController : GenericHotkeyController
	{
		[Ordinal(0)]  [RED("debugCommands")] public CArray<CUInt32> DebugCommands { get; set; }
		[Ordinal(1)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(2)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(3)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(4)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(5)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(6)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(7)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(8)]  [RED("hotkeyBackground")] public inkImageWidgetReference HotkeyBackground { get; set; }
		[Ordinal(9)]  [RED("buttonHint")] public inkWidgetReference ButtonHint { get; set; }
		[Ordinal(10)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(11)]  [RED("pressStarted")] public CBool PressStarted { get; set; }
		[Ordinal(12)]  [RED("buttonHintController")] public CHandle<inkInputDisplayController> ButtonHintController { get; set; }
		[Ordinal(13)]  [RED("questActivatingFact")] public CName QuestActivatingFact { get; set; }
		[Ordinal(14)]  [RED("restrictions")] public CArray<CName> Restrictions { get; set; }
		[Ordinal(15)]  [RED("statusEffectsListener")] public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener { get; set; }
		[Ordinal(16)]  [RED("factListenerId")] public CUInt32 FactListenerId { get; set; }
		[Ordinal(17)]  [RED("mainIcon")] public inkImageWidgetReference MainIcon { get; set; }
		[Ordinal(18)]  [RED("messagePrompt")] public inkTextWidgetReference MessagePrompt { get; set; }
		[Ordinal(19)]  [RED("messageCounter")] public inkTextWidgetReference MessageCounter { get; set; }
		[Ordinal(20)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(21)]  [RED("phoneIconAtlas")] public CString PhoneIconAtlas { get; set; }
		[Ordinal(22)]  [RED("phoneIconName")] public CName PhoneIconName { get; set; }

		public PhoneHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
