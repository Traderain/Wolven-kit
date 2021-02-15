using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputListeners : CVariable
	{
		[Ordinal(0)] [RED("buttonHold")] public CUInt32 ButtonHold { get; set; }
		[Ordinal(1)] [RED("buttonToggle")] public CUInt32 ButtonToggle { get; set; }

		public PlayerVisionModeControllerInputListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
