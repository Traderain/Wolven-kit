using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlob : IRenderResourceBlob
	{
		[Ordinal(0)]  [RED("baseBlob")] public CHandle<IRenderResourceBlob> BaseBlob { get; set; }
		[Ordinal(1)]  [RED("diffsBuffer")] public DataBuffer DiffsBuffer { get; set; }
		[Ordinal(2)]  [RED("header")] public rendRenderMorphTargetMeshBlobHeader Header { get; set; }
		[Ordinal(3)]  [RED("mappingBuffer")] public DataBuffer MappingBuffer { get; set; }
		[Ordinal(4)]  [RED("textureDiffsBuffer")] public serializationDeferredDataBuffer TextureDiffsBuffer { get; set; }

		public rendRenderMorphTargetMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
