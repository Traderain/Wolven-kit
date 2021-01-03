using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("GITransparentColor")] public CColor GITransparentColor { get; set; }
		[Ordinal(1)]  [RED("GIVisibleColor")] public CColor GIVisibleColor { get; set; }

		public worldDebugColoring_GIDebug(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
