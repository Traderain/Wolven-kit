using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeActivationDelayDecoratorDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("delayOnSuccess")] 		public CBehTreeValFloat DelayOnSuccess { get; set;}

		[Ordinal(2)] [RED("delayOnFailure")] 		public CBehTreeValFloat DelayOnFailure { get; set;}

		[Ordinal(3)] [RED("delayOnInterruption")] 		public CBehTreeValFloat DelayOnInterruption { get; set;}

		public CBehTreeNodeActivationDelayDecoratorDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}