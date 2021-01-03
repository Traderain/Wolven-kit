using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleBlockade : ActionBool
	{
		[Ordinal(0)]  [RED("FalseRecordName")] public CString FalseRecordName { get; set; }
		[Ordinal(1)]  [RED("TrueRecordName")] public CString TrueRecordName { get; set; }

		public ToggleBlockade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
