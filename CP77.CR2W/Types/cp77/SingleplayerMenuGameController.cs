using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		[Ordinal(4)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(5)]  [RED("gogButtonWidgetRef")] public inkWidgetReference GogButtonWidgetRef { get; set; }
		[Ordinal(6)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(7)]  [RED("savesCount")] public CInt32 SavesCount { get; set; }

		public SingleplayerMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
