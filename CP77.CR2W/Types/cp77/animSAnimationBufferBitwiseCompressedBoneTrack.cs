using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressedBoneTrack : CVariable
	{
		[Ordinal(0)]  [RED("orientation")] public animSAnimationBufferBitwiseCompressedData Orientation { get; set; }
		[Ordinal(1)]  [RED("position")] public animSAnimationBufferBitwiseCompressedData Position { get; set; }
		[Ordinal(2)]  [RED("scale")] public animSAnimationBufferBitwiseCompressedData Scale { get; set; }

		public animSAnimationBufferBitwiseCompressedBoneTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
