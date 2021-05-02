using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_ManagePchysicalDamageMechanism : W3SwitchEvent
	{
		[Ordinal(1)] [RED("mechanismHandle", 2,0)] 		public CArray<EntityHandle> MechanismHandle { get; set;}

		[Ordinal(2)] [RED("mechanismTag")] 		public CName MechanismTag { get; set;}

		[Ordinal(3)] [RED("operations", 2,0)] 		public CArray<CEnum<EPhysicalDamagemechanismOperation>> Operations { get; set;}

		public W3SE_ManagePchysicalDamageMechanism(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}