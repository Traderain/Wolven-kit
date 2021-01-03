using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_BufferInfo : CVariable
	{
		[Ordinal(0)]  [RED("eyes")] public animFacialSetup_OneSermoBufferInfo Eyes { get; set; }
		[Ordinal(1)]  [RED("face")] public animFacialSetup_OneSermoBufferInfo Face { get; set; }
		[Ordinal(2)]  [RED("numJointRegions")] public CUInt16 NumJointRegions { get; set; }
		[Ordinal(3)]  [RED("numLipsyncOverridesIndexMapping")] public CUInt16 NumLipsyncOverridesIndexMapping { get; set; }
		[Ordinal(4)]  [RED("tongue")] public animFacialSetup_OneSermoBufferInfo Tongue { get; set; }
		[Ordinal(5)]  [RED("tracksMapping")] public animFacialSetup_TracksMapping TracksMapping { get; set; }

		public animFacialSetup_BufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
