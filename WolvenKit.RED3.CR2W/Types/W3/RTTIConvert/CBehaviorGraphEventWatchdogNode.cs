using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEventWatchdogNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(2)] [RED("trueValue")] 		public CFloat TrueValue { get; set;}

		[Ordinal(3)] [RED("falseValue")] 		public CFloat FalseValue { get; set;}

		[Ordinal(4)] [RED("maxTime")] 		public CFloat MaxTime { get; set;}

		[Ordinal(5)] [RED("timeOut")] 		public CFloat TimeOut { get; set;}

		[Ordinal(6)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphEventWatchdogNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}