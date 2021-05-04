using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDiveCheckDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("frontOffset")] 		public CFloat FrontOffset { get; set;}

		[Ordinal(2)] [RED("minWaterDepth")] 		public CFloat MinWaterDepth { get; set;}

		[Ordinal(3)] [RED("maxWaterDistance")] 		public CFloat MaxWaterDistance { get; set;}

		public CBTTaskDiveCheckDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}