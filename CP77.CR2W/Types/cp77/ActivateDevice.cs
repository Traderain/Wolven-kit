using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivateDevice : ActionBool
	{
		[Ordinal(25)] [RED("tweakDBChoiceName")] public CString TweakDBChoiceName { get; set; }

		public ActivateDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
