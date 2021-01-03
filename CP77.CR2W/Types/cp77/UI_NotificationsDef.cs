using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_NotificationsDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("OnscreenMessage")] public gamebbScriptID_Variant OnscreenMessage { get; set; }
		[Ordinal(1)]  [RED("WarningMessage")] public gamebbScriptID_Variant WarningMessage { get; set; }

		public UI_NotificationsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
