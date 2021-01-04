using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Device : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("defaultColor")] public CColor DefaultColor { get; set; }

		public worldDebugColoring_Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
