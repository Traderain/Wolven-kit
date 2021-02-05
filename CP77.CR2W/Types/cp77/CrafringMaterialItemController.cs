using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrafringMaterialItemController : BaseButtonView
	{
		[Ordinal(0)]  [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }
		[Ordinal(1)]  [RED("nameText")] public inkTextWidgetReference NameText { get; set; }
		[Ordinal(2)]  [RED("quantityText")] public inkTextWidgetReference QuantityText { get; set; }
		[Ordinal(3)]  [RED("quantityChangeText")] public inkTextWidgetReference QuantityChangeText { get; set; }
		[Ordinal(4)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(5)]  [RED("frame")] public inkWidgetReference Frame { get; set; }
		[Ordinal(6)]  [RED("data")] public InventoryItemData Data { get; set; }
		[Ordinal(7)]  [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(8)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(9)]  [RED("lastState")] public CEnum<CrafringMaterialItemHighlight> LastState { get; set; }

		public CrafringMaterialItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
