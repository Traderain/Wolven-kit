using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestTeleportBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("locationTag")] 		public TagList LocationTag { get; set;}

		[Ordinal(2)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(3)] [RED("distanceToDestination")] 		public CFloat DistanceToDestination { get; set;}

		[Ordinal(4)] [RED("actorsTags")] 		public TagList ActorsTags { get; set;}

		public CQuestTeleportBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestTeleportBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}