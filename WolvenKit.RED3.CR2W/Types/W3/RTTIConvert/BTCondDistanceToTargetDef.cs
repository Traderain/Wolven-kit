using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondDistanceToTargetDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("attackRange")] 		public CBool AttackRange { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(5)] [RED("predictionTime")] 		public CFloat PredictionTime { get; set;}

		public BTCondDistanceToTargetDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}