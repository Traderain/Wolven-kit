using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFollowOwnerTRG : IBehTreeTask
	{
		[Ordinal(1)] [RED("activationDistance")] 		public CFloat ActivationDistance { get; set;}

		[Ordinal(2)] [RED("minimumDistance")] 		public CFloat MinimumDistance { get; set;}

		[Ordinal(3)] [RED("ignoreEntityWithTag")] 		public CName IgnoreEntityWithTag { get; set;}

		[Ordinal(4)] [RED("attractor")] 		public CHandle<CActor> Attractor { get; set;}

		public CBTTaskFollowOwnerTRG(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}