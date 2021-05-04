using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeAIDespawnInitializer : CSpawnTreeDespawnInitializer
	{
		[Ordinal(1)] [RED("aiDespawnConfiguration")] 		public SSpawnTreeAIDespawnConfiguration AiDespawnConfiguration { get; set;}

		[Ordinal(2)] [RED("ai")] 		public CHandle<CAIDespawnTree> Ai { get; set;}

		[Ordinal(3)] [RED("aiPriority")] 		public CEnum<ETopLevelAIPriorities> AiPriority { get; set;}

		public CSpawnTreeAIDespawnInitializer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}