using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IdleEvents : VehicleEventsTransition
	{
		[Ordinal(0)]  [RED("stateMachineInitData")] public wCHandle<VehicleTransitionInitData> StateMachineInitData { get; set; }
		[Ordinal(1)]  [RED("isCameraTogglePressed")] public CBool IsCameraTogglePressed { get; set; }
		[Ordinal(2)]  [RED("cameraToggleHoldToResetTimeSeconds")] public CFloat CameraToggleHoldToResetTimeSeconds { get; set; }

		public IdleEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
