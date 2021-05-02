using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterSpawnParams : CAISubTreeParameters
	{
		[Ordinal(1)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(2)] [RED("animEventNameActivator")] 		public CName AnimEventNameActivator { get; set;}

		[Ordinal(3)] [RED("playFXOnAnimEvent")] 		public CBool PlayFXOnAnimEvent { get; set;}

		[Ordinal(4)] [RED("monitorGroundContact")] 		public CBool MonitorGroundContact { get; set;}

		[Ordinal(5)] [RED("dealDamageOnAnimEvent")] 		public CName DealDamageOnAnimEvent { get; set;}

		[Ordinal(6)] [RED("becomeVisibleOnAnimEvent")] 		public CName BecomeVisibleOnAnimEvent { get; set;}

		public CAIMonsterSpawnParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}