using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BraindanceBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("Clue")] public gamebbScriptID_Variant Clue { get; set; }
		[Ordinal(1)]  [RED("EnableExit")] public gamebbScriptID_Bool EnableExit { get; set; }
		[Ordinal(2)]  [RED("IsActive")] public gamebbScriptID_Bool IsActive { get; set; }
		[Ordinal(3)]  [RED("IsFPP")] public gamebbScriptID_Bool IsFPP { get; set; }
		[Ordinal(4)]  [RED("PlaybackDirection")] public gamebbScriptID_Variant PlaybackDirection { get; set; }
		[Ordinal(5)]  [RED("PlaybackSpeed")] public gamebbScriptID_Variant PlaybackSpeed { get; set; }
		[Ordinal(6)]  [RED("Progress")] public gamebbScriptID_Float Progress { get; set; }
		[Ordinal(7)]  [RED("SectionTime")] public gamebbScriptID_Float SectionTime { get; set; }
		[Ordinal(8)]  [RED("activeBraindanceVisionMode")] public gamebbScriptID_Int32 ActiveBraindanceVisionMode { get; set; }
		[Ordinal(9)]  [RED("lastBraindanceVisionMode")] public gamebbScriptID_Int32 LastBraindanceVisionMode { get; set; }

		public BraindanceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
