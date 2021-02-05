using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleState : ChangeStanceStateAbstract
	{
		[Ordinal(0)]  [RED("changeStateOnDeactivate")] public CBool ChangeStateOnDeactivate { get; set; }

		public VehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
