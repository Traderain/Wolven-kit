using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttackTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)]  [RED("attackType")] public CEnum<gamedataAttackType> AttackType { get; set; }

		public AttackTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
