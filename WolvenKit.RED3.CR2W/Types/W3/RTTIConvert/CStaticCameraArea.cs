using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStaticCameraArea : CEntity
	{
		[Ordinal(1)] [RED("cameraTag")] 		public CName CameraTag { get; set;}

		[Ordinal(2)] [RED("onlyForPlayer")] 		public CBool OnlyForPlayer { get; set;}

		[Ordinal(3)] [RED("activatorTag")] 		public CName ActivatorTag { get; set;}

		public CStaticCameraArea(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}