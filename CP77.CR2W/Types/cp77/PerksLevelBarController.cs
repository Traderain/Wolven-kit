using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksLevelBarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("foregroundImage")] public inkWidgetReference ForegroundImage { get; set; }
		[Ordinal(2)] [RED("backgroundImage")] public inkWidgetReference BackgroundImage { get; set; }

		public PerksLevelBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
