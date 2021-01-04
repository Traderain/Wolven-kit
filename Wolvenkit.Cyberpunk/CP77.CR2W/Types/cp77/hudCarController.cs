using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudCarController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(1)]  [RED("RPMChunks")] public CArray<inkImageWidgetReference> RPMChunks { get; set; }
		[Ordinal(2)]  [RED("SpeedValue")] public inkTextWidgetReference SpeedValue { get; set; }
		[Ordinal(3)]  [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(4)]  [RED("activeVehicle")] public wCHandle<vehicleBaseObject> ActiveVehicle { get; set; }
		[Ordinal(5)]  [RED("activeVehicleUIBlackboard")] public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard { get; set; }
		[Ordinal(6)]  [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(7)]  [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(8)]  [RED("driver")] public CBool Driver { get; set; }
		[Ordinal(9)]  [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(10)]  [RED("leanAngleBBConnectionId")] public CUInt32 LeanAngleBBConnectionId { get; set; }
		[Ordinal(11)]  [RED("playerStateBBConnectionId")] public CUInt32 PlayerStateBBConnectionId { get; set; }
		[Ordinal(12)]  [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(13)]  [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(14)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(15)]  [RED("tppBBConnectionId")] public CUInt32 TppBBConnectionId { get; set; }
		[Ordinal(16)]  [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }

		public hudCarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
