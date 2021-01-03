using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetingBehaviour : CVariable
	{
		[Ordinal(0)]  [RED("canRotate")] public CBool CanRotate { get; set; }
		[Ordinal(1)]  [RED("initialWakeState")] public CEnum<ESensorDeviceWakeState> InitialWakeState { get; set; }
		[Ordinal(2)]  [RED("lostTargetLookAtTime")] public CFloat LostTargetLookAtTime { get; set; }
		[Ordinal(3)]  [RED("lostTargetSearchTime")] public CFloat LostTargetSearchTime { get; set; }

		public TargetingBehaviour(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
