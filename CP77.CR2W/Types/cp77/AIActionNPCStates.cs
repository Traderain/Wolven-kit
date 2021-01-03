using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionNPCStates : CVariable
	{
		[Ordinal(0)]  [RED("behaviorStates")] public CArray<CEnum<gamedataNPCBehaviorState>> BehaviorStates { get; set; }
		[Ordinal(1)]  [RED("defenseMode")] public CArray<CEnum<gamedataDefenseMode>> DefenseMode { get; set; }
		[Ordinal(2)]  [RED("highLevelStates")] public CArray<CEnum<gamedataNPCHighLevelState>> HighLevelStates { get; set; }
		[Ordinal(3)]  [RED("locomotionMode")] public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode { get; set; }
		[Ordinal(4)]  [RED("stanceStates")] public CArray<CEnum<gamedataNPCStanceState>> StanceStates { get; set; }
		[Ordinal(5)]  [RED("upperBodyStates")] public CArray<CEnum<gamedataNPCUpperBodyState>> UpperBodyStates { get; set; }

		public AIActionNPCStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
