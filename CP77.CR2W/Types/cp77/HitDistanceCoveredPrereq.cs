using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitDistanceCoveredPrereq : GenericHitPrereq
	{
		[Ordinal(0)]  [RED("isSync")] public CBool IsSync { get; set; }
		[Ordinal(1)]  [RED("callbackType")] public CEnum<gameDamageCallbackType> CallbackType { get; set; }
		[Ordinal(2)]  [RED("pipelineStage")] public CEnum<gameDamagePipelineStage> PipelineStage { get; set; }
		[Ordinal(3)]  [RED("attackType")] public CEnum<gamedataAttackType> AttackType { get; set; }
		[Ordinal(4)]  [RED("conditions")] public CArray<CHandle<BaseHitPrereqCondition>> Conditions { get; set; }
		[Ordinal(5)]  [RED("distanceRequired")] public CFloat DistanceRequired { get; set; }
		[Ordinal(6)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public HitDistanceCoveredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
