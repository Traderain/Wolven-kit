using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_DeathMenu : MenuScenario_BaseMenu
	{
		[Ordinal(0)]  [RED("currMenuName")] public CName CurrMenuName { get; set; }
		[Ordinal(1)]  [RED("currUserData")] public CHandle<IScriptable> CurrUserData { get; set; }
		[Ordinal(2)]  [RED("currSubMenuName")] public CName CurrSubMenuName { get; set; }
		[Ordinal(3)]  [RED("prevMenuName")] public CName PrevMenuName { get; set; }

		public MenuScenario_DeathMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
