using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipInventoryItemController : inkButtonDpadSupportedController
	{
		[Ordinal(16)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(17)]  [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(18)]  [RED("empty")] public CBool Empty { get; set; }

		public ArmorEquipInventoryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
