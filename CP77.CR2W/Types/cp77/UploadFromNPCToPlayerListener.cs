using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToPlayerListener : QuickHackUploadListener
	{
		[Ordinal(0)]  [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(2)]  [RED("playerPuppet")] public wCHandle<ScriptedPuppet> PlayerPuppet { get; set; }
		[Ordinal(3)]  [RED("npcPuppet")] public wCHandle<ScriptedPuppet> NpcPuppet { get; set; }
		[Ordinal(4)]  [RED("variantHud")] public HUDProgressBarData VariantHud { get; set; }
		[Ordinal(5)]  [RED("hudBlackboard")] public CHandle<gameIBlackboard> HudBlackboard { get; set; }
		[Ordinal(6)]  [RED("ssAction")] public CBool SsAction { get; set; }

		public UploadFromNPCToPlayerListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
