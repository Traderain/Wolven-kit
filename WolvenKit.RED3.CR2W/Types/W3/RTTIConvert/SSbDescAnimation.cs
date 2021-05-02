using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescAnimation : CVariable
	{
		[Ordinal(1)] [RED("uId")] 		public CInt32 UId { get; set;}

		[Ordinal(2)] [RED("repoAnimId")] 		public CString RepoAnimId { get; set;}

		[Ordinal(3)] [RED("animName")] 		public CString AnimName { get; set;}

		[Ordinal(4)] [RED("frames")] 		public CInt32 Frames { get; set;}

		public SSbDescAnimation(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}