using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendIndexBufferChunk : CVariable
	{
		[Ordinal(0)]  [RED("pe")] public CEnum<GpuWrapApieIndexBufferChunkType> Pe { get; set; }
		[Ordinal(1)]  [RED("teOffset")] public CUInt32 TeOffset { get; set; }

		public rendIndexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
