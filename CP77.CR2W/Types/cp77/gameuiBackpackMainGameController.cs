using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBackpackMainGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("isE3Demo")] public CBool IsE3Demo { get; set; }
		[Ordinal(2)]  [RED("commonCraftingMaterialsGrid")] public inkCompoundWidgetReference CommonCraftingMaterialsGrid { get; set; }
		[Ordinal(3)]  [RED("hackingCraftingMaterialsGrid")] public inkCompoundWidgetReference HackingCraftingMaterialsGrid { get; set; }
		[Ordinal(4)]  [RED("filterButtonsGrid")] public inkCompoundWidgetReference FilterButtonsGrid { get; set; }
		[Ordinal(5)]  [RED("virtualItemsGrid")] public inkVirtualCompoundWidgetReference VirtualItemsGrid { get; set; }
		[Ordinal(6)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(7)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(8)]  [RED("sortingButton")] public inkWidgetReference SortingButton { get; set; }
		[Ordinal(9)]  [RED("sortingDropdown")] public inkWidgetReference SortingDropdown { get; set; }
		[Ordinal(10)]  [RED("itemsListScrollAreaContainer")] public inkWidgetReference ItemsListScrollAreaContainer { get; set; }
		[Ordinal(11)]  [RED("itemNotificationRoot")] public inkWidgetReference ItemNotificationRoot { get; set; }
		[Ordinal(12)]  [RED("virtualBackpackItemsListController")] public wCHandle<inkGridController> VirtualBackpackItemsListController { get; set; }
		[Ordinal(13)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(14)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(15)]  [RED("itemTypeSorting")] public CArray<CEnum<gamedataItemType>> ItemTypeSorting { get; set; }
		[Ordinal(16)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(17)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(18)]  [RED("itemDropQueue")] public CArray<gameItemModParams> ItemDropQueue { get; set; }
		[Ordinal(19)]  [RED("craftingMaterialsListItems")] public CArray<CHandle<CrafringMaterialItemController>> CraftingMaterialsListItems { get; set; }
		[Ordinal(20)]  [RED("DisassembleCallback")] public CHandle<UI_CraftingDef> DisassembleCallback { get; set; }
		[Ordinal(21)]  [RED("DisassembleBlackboard")] public CHandle<gameIBlackboard> DisassembleBlackboard { get; set; }
		[Ordinal(22)]  [RED("DisassembleBBID")] public CUInt32 DisassembleBBID { get; set; }
		[Ordinal(23)]  [RED("EquippedCallback")] public CHandle<UI_EquipmentDef> EquippedCallback { get; set; }
		[Ordinal(24)]  [RED("EquippedBlackboard")] public CHandle<gameIBlackboard> EquippedBlackboard { get; set; }
		[Ordinal(25)]  [RED("EquippedBBID")] public CUInt32 EquippedBBID { get; set; }
		[Ordinal(26)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(27)]  [RED("activeFilter")] public CHandle<BackpackFilterButtonController> ActiveFilter { get; set; }
		[Ordinal(28)]  [RED("backpackItemsDataSource")] public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource { get; set; }
		[Ordinal(29)]  [RED("backpackItemsDataView")] public CHandle<BackpackDataView> BackpackItemsDataView { get; set; }
		[Ordinal(30)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(31)]  [RED("backpackInventoryListenerCallback")] public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback { get; set; }
		[Ordinal(32)]  [RED("backpackInventoryListener")] public CHandle<gameInventoryScriptListener> BackpackInventoryListener { get; set; }
		[Ordinal(33)]  [RED("backpackItemsClassifier")] public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier { get; set; }
		[Ordinal(34)]  [RED("backpackItemsPositionProvider")] public CHandle<ItemPositionProvider> BackpackItemsPositionProvider { get; set; }
		[Ordinal(35)]  [RED("equipSlotChooserPopupToken")] public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken { get; set; }
		[Ordinal(36)]  [RED("quantityPickerPopupToken")] public CHandle<inkGameNotificationToken> QuantityPickerPopupToken { get; set; }
		[Ordinal(37)]  [RED("equipRequested")] public CBool EquipRequested { get; set; }
		[Ordinal(38)]  [RED("psmBlackboard")] public wCHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(39)]  [RED("playerState")] public CEnum<gamePSMVehicle> PlayerState { get; set; }
		[Ordinal(40)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(41)]  [RED("itemPreviewPopupToken")] public CHandle<inkGameNotificationToken> ItemPreviewPopupToken { get; set; }
		[Ordinal(42)]  [RED("afterCloseRequest")] public CBool AfterCloseRequest { get; set; }

		public gameuiBackpackMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
