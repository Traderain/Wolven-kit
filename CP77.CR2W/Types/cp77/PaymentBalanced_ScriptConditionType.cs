using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PaymentBalanced_ScriptConditionType : PaymentConditionTypeBase
	{
		[Ordinal(0)]  [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }
		[Ordinal(1)]  [RED("questAssignment")] public TweakDBID QuestAssignment { get; set; }

		public PaymentBalanced_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
