using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ProceduralIronsightData : animAnimFeature
	{
		[Ordinal(0)]  [RED("hasScope")] public CBool HasScope { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(3)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(4)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(5)]  [RED("scopeOffset")] public CFloat ScopeOffset { get; set; }

		public AnimFeature_ProceduralIronsightData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
