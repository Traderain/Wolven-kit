using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryComboBoxData : CVariable
	{
		[Ordinal(0)]  [RED("DisplayShowcase")] public CBool DisplayShowcase { get; set; }
		[Ordinal(1)]  [RED("ForceDouble")] public CBool ForceDouble { get; set; }
		[Ordinal(2)]  [RED("ItemsToDisplay")] public CArray<InventoryItemData> ItemsToDisplay { get; set; }
		[Ordinal(3)]  [RED("Message")] public CString Message { get; set; }
		[Ordinal(4)]  [RED("ShowUnequipButton")] public CBool ShowUnequipButton { get; set; }
		[Ordinal(5)]  [RED("ShowcaseItem")] public InventoryItemData ShowcaseItem { get; set; }

		public InventoryComboBoxData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
