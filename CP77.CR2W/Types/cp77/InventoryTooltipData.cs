using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("DEBUG_iconErrorInfo")] public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("isEquipped")] public CBool IsEquipped { get; set; }
		[Ordinal(3)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(4)]  [RED("isVendorItem")] public CBool IsVendorItem { get; set; }
		[Ordinal(5)]  [RED("isCraftable")] public CBool IsCraftable { get; set; }
		[Ordinal(6)]  [RED("qualityStateName")] public CName QualityStateName { get; set; }
		[Ordinal(7)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(8)]  [RED("additionalDescription")] public CString AdditionalDescription { get; set; }
		[Ordinal(9)]  [RED("category")] public CString Category { get; set; }
		[Ordinal(10)]  [RED("quality")] public CString Quality { get; set; }
		[Ordinal(11)]  [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(12)]  [RED("price")] public CFloat Price { get; set; }
		[Ordinal(13)]  [RED("buyPrice")] public CFloat BuyPrice { get; set; }
		[Ordinal(14)]  [RED("unlockProgress")] public CFloat UnlockProgress { get; set; }
		[Ordinal(15)]  [RED("primaryStats")] public CArray<InventoryTooltipData_StatData> PrimaryStats { get; set; }
		[Ordinal(16)]  [RED("comparedStats")] public CArray<InventoryTooltipData_StatData> ComparedStats { get; set; }
		[Ordinal(17)]  [RED("additionalStats")] public CArray<InventoryTooltipData_StatData> AdditionalStats { get; set; }
		[Ordinal(18)]  [RED("randomDamageTypes")] public CArray<InventoryTooltipData_StatData> RandomDamageTypes { get; set; }
		[Ordinal(19)]  [RED("recipeAdditionalStats")] public CArray<InventoryTooltipData_StatData> RecipeAdditionalStats { get; set; }
		[Ordinal(20)]  [RED("damageType")] public CEnum<gamedataDamageType> DamageType { get; set; }
		[Ordinal(21)]  [RED("isBroken")] public CBool IsBroken { get; set; }
		[Ordinal(22)]  [RED("levelRequired")] public CInt32 LevelRequired { get; set; }
		[Ordinal(23)]  [RED("attachments")] public CArray<CName> Attachments { get; set; }
		[Ordinal(24)]  [RED("specialAbilities")] public CArray<gameInventoryItemAbility> SpecialAbilities { get; set; }
		[Ordinal(25)]  [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }
		[Ordinal(26)]  [RED("showCyclingDots")] public CBool ShowCyclingDots { get; set; }
		[Ordinal(27)]  [RED("numberOfCyclingDots")] public CInt32 NumberOfCyclingDots { get; set; }
		[Ordinal(28)]  [RED("selectedCyclingDot")] public CInt32 SelectedCyclingDot { get; set; }
		[Ordinal(29)]  [RED("comparedQuality")] public CEnum<gamedataQuality> ComparedQuality { get; set; }
		[Ordinal(30)]  [RED("showIcon")] public CBool ShowIcon { get; set; }
		[Ordinal(31)]  [RED("randomizedStatQuantity")] public CInt32 RandomizedStatQuantity { get; set; }
		[Ordinal(32)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(33)]  [RED("HasPlayerSmartGunLink")] public CBool HasPlayerSmartGunLink { get; set; }
		[Ordinal(34)]  [RED("PlayerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(35)]  [RED("PlayerStrenght")] public CInt32 PlayerStrenght { get; set; }
		[Ordinal(36)]  [RED("PlayerReflexes")] public CInt32 PlayerReflexes { get; set; }
		[Ordinal(37)]  [RED("PlayerStreetCred")] public CInt32 PlayerStreetCred { get; set; }
		[Ordinal(38)]  [RED("itemAttachments")] public CArray<InventoryItemAttachments> ItemAttachments { get; set; }
		[Ordinal(39)]  [RED("inventoryItemData")] public InventoryItemData InventoryItemData { get; set; }
		[Ordinal(40)]  [RED("overrideRarity")] public CBool OverrideRarity { get; set; }
		[Ordinal(41)]  [RED("quickhackData")] public InventoryTooltipData_QuickhackData QuickhackData { get; set; }
		[Ordinal(42)]  [RED("grenadeData")] public CHandle<InventoryTooltiData_GrenadeData> GrenadeData { get; set; }
		[Ordinal(43)]  [RED("displayContext")] public CEnum<InventoryTooltipDisplayContext> DisplayContext { get; set; }
		[Ordinal(44)]  [RED("parentItemData")] public wCHandle<gameItemData> ParentItemData { get; set; }
		[Ordinal(45)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public InventoryTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
