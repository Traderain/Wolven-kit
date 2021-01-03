using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_PrefabProxy : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("distinguishInstancedMesh")] public CBool DistinguishInstancedMesh { get; set; }
		[Ordinal(1)]  [RED("instancedMeshColor")] public CColor InstancedMeshColor { get; set; }
		[Ordinal(2)]  [RED("prefabProxyMeshColor")] public CColor PrefabProxyMeshColor { get; set; }
		[Ordinal(3)]  [RED("regularMeshColor")] public CColor RegularMeshColor { get; set; }

		public worldDebugColoring_PrefabProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
