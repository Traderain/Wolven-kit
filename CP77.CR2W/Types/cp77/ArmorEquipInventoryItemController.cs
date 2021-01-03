using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipInventoryItemController : inkButtonDpadSupportedController
	{
		[Ordinal(0)]  [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(1)]  [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(2)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public ArmorEquipInventoryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
