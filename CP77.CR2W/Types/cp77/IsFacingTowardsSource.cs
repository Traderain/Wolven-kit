using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IsFacingTowardsSource : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)]  [RED("applyForNPCs")] public CBool ApplyForNPCs { get; set; }
		[Ordinal(1)]  [RED("applyForPlayer")] public CBool ApplyForPlayer { get; set; }
		[Ordinal(2)]  [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(3)]  [RED("maxAllowedAnglePitch")] public CFloat MaxAllowedAnglePitch { get; set; }
		[Ordinal(4)]  [RED("maxAllowedAngleYaw")] public CFloat MaxAllowedAngleYaw { get; set; }

		public IsFacingTowardsSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
