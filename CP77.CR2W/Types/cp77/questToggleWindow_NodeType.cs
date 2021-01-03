using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questToggleWindow_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(2)]  [RED("windowState")] public CEnum<vehicleEQuestVehicleWindowState> WindowState { get; set; }

		public questToggleWindow_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
