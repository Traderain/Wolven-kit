using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSnapToTerrainIkRequest : CVariable
	{
		[Ordinal(0)]  [RED("enableFootLockFloatTrack")] public animNamedTrackIndex EnableFootLockFloatTrack { get; set; }
		[Ordinal(1)]  [RED("footTransformIndex")] public animTransformIndex FootTransformIndex { get; set; }
		[Ordinal(2)]  [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(3)]  [RED("poleVectorRefTransformIndex")] public animTransformIndex PoleVectorRefTransformIndex { get; set; }

		public animSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
