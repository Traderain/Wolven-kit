using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleParams : CVariable
	{
		[Ordinal(0)]  [RED("meshComponents")] public CArray<gameMeshDef> MeshComponents { get; set; }
		[Ordinal(1)]  [RED("visionTag")] public CName VisionTag { get; set; }

		public gameVisionModuleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
