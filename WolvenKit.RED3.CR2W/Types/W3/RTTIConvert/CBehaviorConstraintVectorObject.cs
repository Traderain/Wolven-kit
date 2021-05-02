using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintVectorObject : IBehaviorConstraintObject
	{
		[Ordinal(1)] [RED("cachedTargetPositionNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPositionNode { get; set;}

		[Ordinal(2)] [RED("cachedTargetRotationNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotationNode { get; set;}

		public CBehaviorConstraintVectorObject(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}