using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class senseAngleRange : senseIShape
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("halfHeight")] public CFloat HalfHeight { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(3)]  [RED("range")] public CFloat Range { get; set; }

		public senseAngleRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
