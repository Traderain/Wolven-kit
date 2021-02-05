using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KnifeLookAtEvents : LookAtPresetMeleeBaseEvents
	{
		[Ordinal(0)]  [RED("lookAtEvents")] public CArray<CHandle<entLookAtAddEvent>> LookAtEvents { get; set; }
		[Ordinal(1)]  [RED("attachLeft")] public CBool AttachLeft { get; set; }
		[Ordinal(2)]  [RED("attachRight")] public CBool AttachRight { get; set; }

		public KnifeLookAtEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
