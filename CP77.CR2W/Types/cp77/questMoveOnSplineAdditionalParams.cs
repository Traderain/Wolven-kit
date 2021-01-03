using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineAdditionalParams : ISerializable
	{
		[Ordinal(0)]  [RED("animParams")] public questAnimMoveOnSplineParams AnimParams { get; set; }
		[Ordinal(1)]  [RED("simpleParams")] public questSimpleMoveOnSplineParams SimpleParams { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<questMoveOnSplineType> Type { get; set; }
		[Ordinal(3)]  [RED("withCompanionParams")] public questWithCompanionMoveOnSplineParams WithCompanionParams { get; set; }

		public questMoveOnSplineAdditionalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
