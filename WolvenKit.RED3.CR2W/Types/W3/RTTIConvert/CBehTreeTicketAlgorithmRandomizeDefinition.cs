using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTicketAlgorithmRandomizeDefinition : IBehTreeTicketAlgorithmDecoratorDefinition
	{
		[Ordinal(1)] [RED("randMin")] 		public CBehTreeValFloat RandMin { get; set;}

		[Ordinal(2)] [RED("randMax")] 		public CBehTreeValFloat RandMax { get; set;}

		public CBehTreeTicketAlgorithmRandomizeDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}