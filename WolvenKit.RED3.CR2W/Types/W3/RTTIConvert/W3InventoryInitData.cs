using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3InventoryInitData : W3MenuInitData
	{
		[Ordinal(1)] [RED("containerNPC")] 		public CHandle<CGameplayEntity> ContainerNPC { get; set;}

		[Ordinal(2)] [RED("filterTagsList", 2,0)] 		public CArray<CName> FilterTagsList { get; set;}

		public W3InventoryInitData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}