using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("attackSubtype")] public CEnum<gamedataAttackSubtype> AttackSubtype { get; set; }

		public AttackSubtypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
