using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipClothingInfoModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("lineWidget")] public inkWidgetReference LineWidget { get; set; }
		[Ordinal(1)]  [RED("value")] public inkTextWidgetReference Value { get; set; }
		[Ordinal(2)]  [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }

		public ItemTooltipClothingInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
