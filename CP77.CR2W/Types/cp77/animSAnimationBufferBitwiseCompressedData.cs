using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressedData : CVariable
	{
		[Ordinal(0)]  [RED("compression")] public CInt8 Compression { get; set; }
		[Ordinal(1)]  [RED("dataAddr")] public CUInt32 DataAddr { get; set; }
		[Ordinal(2)]  [RED("dataAddrFallback")] public CUInt32 DataAddrFallback { get; set; }
		[Ordinal(3)]  [RED("dt")] public CFloat Dt { get; set; }
		[Ordinal(4)]  [RED("numFrames")] public CUInt16 NumFrames { get; set; }

		public animSAnimationBufferBitwiseCompressedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
