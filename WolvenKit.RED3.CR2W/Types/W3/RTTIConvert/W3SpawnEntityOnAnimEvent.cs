using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SpawnEntityOnAnimEvent : CScriptedComponent
	{
		[Ordinal(1)] [RED("animEvent")] 		public CName AnimEvent { get; set;}

		[Ordinal(2)] [RED("entityName")] 		public CName EntityName { get; set;}

		[Ordinal(3)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		public W3SpawnEntityOnAnimEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}