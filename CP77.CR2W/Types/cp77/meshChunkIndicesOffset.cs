using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshChunkIndicesOffset : CVariable
	{
		[Ordinal(0)]  [RED("boneIndex")] public CUInt8 BoneIndex { get; set; }
		[Ordinal(1)]  [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(2)]  [RED("start")] public CUInt32 Start { get; set; }

		public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
