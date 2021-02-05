using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		[Ordinal(0)]  [RED("itemSceneInfos")] public CArray<gameuiInGameMenuGameControllerItemSceneInfo> ItemSceneInfos { get; set; }
		[Ordinal(1)]  [RED("garmentSwitchEffectControllers")] public CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> GarmentSwitchEffectControllers { get; set; }
		[Ordinal(2)]  [RED("quickSaveInProgress")] public CBool QuickSaveInProgress { get; set; }
		[Ordinal(3)]  [RED("showDeathScreenBBID")] public CUInt32 ShowDeathScreenBBID { get; set; }
		[Ordinal(4)]  [RED("breachingNetworkBBID")] public CUInt32 BreachingNetworkBBID { get; set; }
		[Ordinal(5)]  [RED("triggerMenuEventBBID")] public CUInt32 TriggerMenuEventBBID { get; set; }
		[Ordinal(6)]  [RED("openStorageBBID")] public CUInt32 OpenStorageBBID { get; set; }
		[Ordinal(7)]  [RED("bbOnEquipmentChangedID")] public CUInt32 BbOnEquipmentChangedID { get; set; }
		[Ordinal(8)]  [RED("inventoryListener")] public CHandle<gameAttachmentSlotsScriptListener> InventoryListener { get; set; }

		public gameuiInGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
