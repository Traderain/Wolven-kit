using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSpawnTreeDespawnConfiguration : CVariable
	{
		[Ordinal(1)] [RED("canDespawnOnSight")] 		public CBool CanDespawnOnSight { get; set;}

		[Ordinal(2)] [RED("minDespawnRange")] 		public CFloat MinDespawnRange { get; set;}

		[Ordinal(3)] [RED("forceDespawnRange")] 		public CFloat ForceDespawnRange { get; set;}

		[Ordinal(4)] [RED("despawnDelayMin")] 		public CFloat DespawnDelayMin { get; set;}

		[Ordinal(5)] [RED("despawnDelayMax")] 		public CFloat DespawnDelayMax { get; set;}

		[Ordinal(6)] [RED("despawnTime")] 		public CFloat DespawnTime { get; set;}

		public SSpawnTreeDespawnConfiguration(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}