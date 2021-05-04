using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CreaturesGroupEnabledCondition : ISpawnScriptCondition
	{
		[Ordinal(1)] [RED("groupName")] 		public CName GroupName { get; set;}

		[Ordinal(2)] [RED("disabledBySources")] 		public CInt32 DisabledBySources { get; set;}

		[Ordinal(3)] [RED("dataManager")] 		public CHandle<CEncounterDataManager> DataManager { get; set;}

		public W3CreaturesGroupEnabledCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}