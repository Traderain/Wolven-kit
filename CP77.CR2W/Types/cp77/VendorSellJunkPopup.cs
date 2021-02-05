using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopup : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(1)]  [RED("buttonHintsRoot")] public inkWidgetReference ButtonHintsRoot { get; set; }
		[Ordinal(2)]  [RED("itemDisplayRef")] public inkWidgetReference ItemDisplayRef { get; set; }
		[Ordinal(3)]  [RED("rairtyBar")] public inkWidgetReference RairtyBar { get; set; }
		[Ordinal(4)]  [RED("eqippedItemContainer")] public inkWidgetReference EqippedItemContainer { get; set; }
		[Ordinal(5)]  [RED("itemPriceContainer")] public inkWidgetReference ItemPriceContainer { get; set; }
		[Ordinal(6)]  [RED("itemPriceText")] public inkTextWidgetReference ItemPriceText { get; set; }
		[Ordinal(7)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(8)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(9)]  [RED("sellItemsFullQuantity")] public inkTextWidgetReference SellItemsFullQuantity { get; set; }
		[Ordinal(10)]  [RED("sellItemsLimitedQuantity")] public inkTextWidgetReference SellItemsLimitedQuantity { get; set; }
		[Ordinal(11)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(12)]  [RED("gameData")] public CHandle<gameItemData> GameData { get; set; }
		[Ordinal(13)]  [RED("buttonOk")] public inkWidgetReference ButtonOk { get; set; }
		[Ordinal(14)]  [RED("buttonCancel")] public inkWidgetReference ButtonCancel { get; set; }
		[Ordinal(15)]  [RED("closeAnimProxy")] public CHandle<inkanimProxy> CloseAnimProxy { get; set; }
		[Ordinal(16)]  [RED("data")] public CHandle<VendorSellJunkPopupData> Data { get; set; }
		[Ordinal(17)]  [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(18)]  [RED("closeData")] public CHandle<VendorSellJunkPopupCloseData> CloseData { get; set; }

		public VendorSellJunkPopup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
