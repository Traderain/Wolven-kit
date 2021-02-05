using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(0)]  [RED("itemContainer")] public inkCompoundWidgetReference ItemContainer { get; set; }
		[Ordinal(1)]  [RED("slotsCategory")] public inkWidgetReference SlotsCategory { get; set; }
		[Ordinal(2)]  [RED("slotsRootContainer")] public inkWidgetReference SlotsRootContainer { get; set; }
		[Ordinal(3)]  [RED("slotsRootLabel")] public inkTextWidgetReference SlotsRootLabel { get; set; }
		[Ordinal(4)]  [RED("slotsContainer")] public inkCompoundWidgetReference SlotsContainer { get; set; }
		[Ordinal(5)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(6)]  [RED("inventoryDataManager")] public CHandle<InventoryDataManagerV2> InventoryDataManager { get; set; }
		[Ordinal(7)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(8)]  [RED("itemDisplay")] public CHandle<InventoryItemDisplayController> ItemDisplay { get; set; }
		[Ordinal(9)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(10)]  [RED("selectedItem")] public CHandle<InventoryItemDisplayController> SelectedItem { get; set; }
		[Ordinal(11)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(12)]  [RED("scopeRootContainer")] public inkCompoundWidgetReference ScopeRootContainer { get; set; }
		[Ordinal(13)]  [RED("magazineRootContainer")] public inkCompoundWidgetReference MagazineRootContainer { get; set; }
		[Ordinal(14)]  [RED("silencerRootContainer")] public inkCompoundWidgetReference SilencerRootContainer { get; set; }
		[Ordinal(15)]  [RED("scopeContainer")] public inkCompoundWidgetReference ScopeContainer { get; set; }
		[Ordinal(16)]  [RED("magazineContainer")] public inkCompoundWidgetReference MagazineContainer { get; set; }
		[Ordinal(17)]  [RED("silencerContainer")] public inkCompoundWidgetReference SilencerContainer { get; set; }
		[Ordinal(18)]  [RED("attachmentsLabel")] public inkTextWidgetReference AttachmentsLabel { get; set; }
		[Ordinal(19)]  [RED("attachmentsContainer")] public inkWidgetReference AttachmentsContainer { get; set; }
		[Ordinal(20)]  [RED("softwareModsLabel")] public inkTextWidgetReference SoftwareModsLabel { get; set; }
		[Ordinal(21)]  [RED("softwareModsPush")] public inkWidgetReference SoftwareModsPush { get; set; }
		[Ordinal(22)]  [RED("softwareModsContainer")] public inkWidgetReference SoftwareModsContainer { get; set; }

		public InventoryWeaponItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
