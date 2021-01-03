using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("CurrentFloor")] public gamebbScriptID_String CurrentFloor { get; set; }
		[Ordinal(1)]  [RED("isPaused")] public gamebbScriptID_Bool IsPaused { get; set; }
		[Ordinal(2)]  [RED("isPlayerScanned")] public gamebbScriptID_Bool IsPlayerScanned { get; set; }

		public ElevatorDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
