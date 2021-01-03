using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TooltipLootingCachedData : IScriptable
	{
		[Ordinal(0)]  [RED("comparisionItemData")] public wCHandle<gameItemData> ComparisionItemData { get; set; }
		[Ordinal(1)]  [RED("externalItemData")] public wCHandle<gameItemData> ExternalItemData { get; set; }
		[Ordinal(2)]  [RED("itemRecord")] public wCHandle<gamedataItem_Record> ItemRecord { get; set; }
		[Ordinal(3)]  [RED("lootingData")] public CHandle<MinimalLootingListItemData> LootingData { get; set; }

		public TooltipLootingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
