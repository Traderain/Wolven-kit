using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHorsePlayAnimWithRider : IBehTreeTask
	{
		[Ordinal(1)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(2)] [RED("deactivationEventName")] 		public CName DeactivationEventName { get; set;}

		[Ordinal(3)] [RED("workDone")] 		public CBool WorkDone { get; set;}

		public CBTTaskHorsePlayAnimWithRider(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}