using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGraphConnection : ISerializable
	{
		[Ordinal(1)] [RED("source")] 		public CPtr<CGraphSocket> Source { get; set;}

		[Ordinal(2)] [RED("destination")] 		public CPtr<CGraphSocket> Destination { get; set;}

		[Ordinal(3)] [RED("inactive")] 		public CBool Inactive { get; set;}

		public CGraphConnection(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}