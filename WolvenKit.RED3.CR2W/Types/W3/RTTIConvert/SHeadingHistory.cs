using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHeadingHistory : CVariable
	{
		[Ordinal(1)] [RED("time")] 		public EngineTime Time { get; set;}

		[Ordinal(2)] [RED("headValue")] 		public CFloat HeadValue { get; set;}

		[Ordinal(3)] [RED("speedValue")] 		public CFloat SpeedValue { get; set;}

		public SHeadingHistory(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}