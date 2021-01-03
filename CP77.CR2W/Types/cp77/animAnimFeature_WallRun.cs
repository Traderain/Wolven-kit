using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WallRun : animAnimFeature
	{
		[Ordinal(0)]  [RED("wallNormal")] public Vector4 WallNormal { get; set; }
		[Ordinal(1)]  [RED("wallOnRightSide")] public CBool WallOnRightSide { get; set; }
		[Ordinal(2)]  [RED("wallPosition")] public Vector4 WallPosition { get; set; }

		public animAnimFeature_WallRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
