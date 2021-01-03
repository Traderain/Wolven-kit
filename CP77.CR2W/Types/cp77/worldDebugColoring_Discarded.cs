using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Discarded : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }

		public worldDebugColoring_Discarded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
