using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class OrientedBox : CVariable
	{
		[Ordinal(1)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(2)] [RED("edge 1")] 		public Vector Edge_1 { get; set;}

		[Ordinal(3)] [RED("edge 2")] 		public Vector Edge_2 { get; set;}

		public OrientedBox(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}