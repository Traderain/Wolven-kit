using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatsPlayTimeController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("lifePathIconRef")] public inkImageWidgetReference LifePathIconRef { get; set; }
		[Ordinal(1)]  [RED("lifePathRef")] public inkTextWidgetReference LifePathRef { get; set; }
		[Ordinal(2)]  [RED("playTimeRef")] public inkTextWidgetReference PlayTimeRef { get; set; }

		public StatsPlayTimeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
