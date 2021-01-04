using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteractionStateChange : ActionBool
	{
		[Ordinal(0)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }
		[Ordinal(1)]  [RED("newState")] public CEnum<vehicleVehicleDoorInteractionState> NewState { get; set; }
		[Ordinal(2)]  [RED("source")] public CString Source { get; set; }

		public VehicleDoorInteractionStateChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
