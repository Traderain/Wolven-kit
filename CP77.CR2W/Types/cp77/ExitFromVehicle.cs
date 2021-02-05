using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExitFromVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)]  [RED("useFastExit")] public CBool UseFastExit { get; set; }
		[Ordinal(1)]  [RED("tryBlendToWalk")] public CBool TryBlendToWalk { get; set; }

		public ExitFromVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
