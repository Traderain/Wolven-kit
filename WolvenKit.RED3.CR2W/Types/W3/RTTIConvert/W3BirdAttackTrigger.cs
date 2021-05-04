using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BirdAttackTrigger : CEntity
	{
		[Ordinal(1)] [RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(2)] [RED("affectedEntityTag")] 		public CName AffectedEntityTag { get; set;}

		[Ordinal(3)] [RED("attackRequestInterval")] 		public CFloat AttackRequestInterval { get; set;}

		[Ordinal(4)] [RED("affectBirdsInRange")] 		public CFloat AffectBirdsInRange { get; set;}

		public W3BirdAttackTrigger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}