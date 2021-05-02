using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SClosestSpotFilter : CVariable
	{
		[Ordinal(1)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(2)] [RED("zDiff")] 		public CFloat ZDiff { get; set;}

		[Ordinal(3)] [RED("awayFromCamera")] 		public CBool AwayFromCamera { get; set;}

		[Ordinal(4)] [RED("onlyReachable")] 		public CBool OnlyReachable { get; set;}

		[Ordinal(5)] [RED("noRoughTerrain")] 		public CBool NoRoughTerrain { get; set;}

		[Ordinal(6)] [RED("noInteriors")] 		public CBool NoInteriors { get; set;}

		[Ordinal(7)] [RED("limitToBaseArea")] 		public CBool LimitToBaseArea { get; set;}

		[Ordinal(8)] [RED("limitedPrecision")] 		public CBool LimitedPrecision { get; set;}

		public SClosestSpotFilter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}