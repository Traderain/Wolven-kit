using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LedColors : CVariable
	{
		[Ordinal(0)]  [RED("off")] public ScriptLightSettings Off { get; set; }
		[Ordinal(1)]  [RED("red")] public ScriptLightSettings Red { get; set; }
		[Ordinal(2)]  [RED("green")] public ScriptLightSettings Green { get; set; }

		public LedColors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
