using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class netChargesWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("bbPlayerEventId1")] public CUInt32 BbPlayerEventId1 { get; set; }
		[Ordinal(1)]  [RED("bbPlayerEventId2")] public CUInt32 BbPlayerEventId2 { get; set; }
		[Ordinal(2)]  [RED("bbPlayerEventId3")] public CUInt32 BbPlayerEventId3 { get; set; }
		[Ordinal(3)]  [RED("bbPlayerStats")] public CHandle<gameIBlackboard> BbPlayerStats { get; set; }
		[Ordinal(4)]  [RED("chargeList")] public wCHandle<inkHorizontalPanelWidget> ChargeList { get; set; }
		[Ordinal(5)]  [RED("chargesCurrent")] public CInt32 ChargesCurrent { get; set; }
		[Ordinal(6)]  [RED("chargesList")] public CArray<wCHandle<inkCompoundWidget>> ChargesList { get; set; }
		[Ordinal(7)]  [RED("chargesMax")] public CInt32 ChargesMax { get; set; }
		[Ordinal(8)]  [RED("networkName")] public wCHandle<inkTextWidget> NetworkName { get; set; }
		[Ordinal(9)]  [RED("networkNameText")] public CString NetworkNameText { get; set; }
		[Ordinal(10)]  [RED("networkStatus")] public wCHandle<inkTextWidget> NetworkStatus { get; set; }
		[Ordinal(11)]  [RED("networkStatusText")] public CString NetworkStatusText { get; set; }
		[Ordinal(12)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public netChargesWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
