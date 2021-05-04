using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAttackEventData : CVariable
	{
		[Ordinal(1)] [RED("animData")] 		public CPreAttackEventData AnimData { get; set;}

		[Ordinal(2)] [RED("weaponId")] 		public SItemUniqueId WeaponId { get; set;}

		[Ordinal(3)] [RED("parriedBy", 2,0)] 		public CArray<CHandle<CActor>> ParriedBy { get; set;}

		public SAttackEventData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}