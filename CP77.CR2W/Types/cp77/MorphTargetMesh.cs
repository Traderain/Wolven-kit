using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMesh : resStreamedResource
	{
		[Ordinal(0)]  [RED("baseMesh")] public rRef<CMesh> BaseMesh { get; set; }
		[Ordinal(1)]  [RED("baseMeshAppearance")] public CName BaseMeshAppearance { get; set; }
		[Ordinal(2)]  [RED("baseTexture")] public rRef<ITexture> BaseTexture { get; set; }
		[Ordinal(3)]  [RED("baseTextureParamName")] public CName BaseTextureParamName { get; set; }
		[Ordinal(4)]  [RED("blob")] public CHandle<IRenderResourceBlob> Blob { get; set; }
		[Ordinal(5)]  [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(6)]  [RED("targets")] public CArray<MorphTargetMeshEntry> Targets { get; set; }

		public MorphTargetMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
