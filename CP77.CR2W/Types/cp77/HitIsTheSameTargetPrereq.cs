using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereq : GenericHitPrereq
	{
		[Ordinal(5)]  [RED("isMoving")] public CBool IsMoving { get; set; }
		[Ordinal(6)]  [RED("object")] public CString Object { get; set; }
		[Ordinal(7)]  [RED("invert")] public CBool Invert { get; set; }

		public HitIsTheSameTargetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
