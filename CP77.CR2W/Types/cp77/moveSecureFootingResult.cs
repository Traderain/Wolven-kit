using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingResult : CVariable
	{
		[Ordinal(0)]  [RED("lowestLocalPosition")] public Vector4 LowestLocalPosition { get; set; }
		[Ordinal(1)]  [RED("normalDirection")] public Vector4 NormalDirection { get; set; }
		[Ordinal(2)]  [RED("reason")] public CEnum<moveSecureFootingFailureReason> Reason { get; set; }
		[Ordinal(3)]  [RED("slidingDirection")] public Vector4 SlidingDirection { get; set; }
		[Ordinal(4)]  [RED("staticGroundFactor")] public CFloat StaticGroundFactor { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<moveSecureFootingFailureType> Type { get; set; }

		public moveSecureFootingResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
