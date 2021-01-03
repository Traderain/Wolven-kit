using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(1)]  [RED("itemCategory")] public CEnum<gamedataItemCategory> ItemCategory { get; set; }
		[Ordinal(2)]  [RED("itemTag")] public CName ItemTag { get; set; }
		[Ordinal(3)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(4)]  [RED("skipOnApply")] public CBool SkipOnApply { get; set; }
		[Ordinal(5)]  [RED("slotCheckType")] public CEnum<EItemSlotCheckType> SlotCheckType { get; set; }
		[Ordinal(6)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(7)]  [RED("weaponEvolution")] public CEnum<gamedataWeaponEvolution> WeaponEvolution { get; set; }

		public ItemInSlotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
