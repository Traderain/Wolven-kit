using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDepthOfFieldParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("nearBlurDist")] 		public SSimpleCurve NearBlurDist { get; set;}

		[Ordinal(3)] [RED("nearFocusDist")] 		public SSimpleCurve NearFocusDist { get; set;}

		[Ordinal(4)] [RED("farFocusDist")] 		public SSimpleCurve FarFocusDist { get; set;}

		[Ordinal(5)] [RED("farBlurDist")] 		public SSimpleCurve FarBlurDist { get; set;}

		[Ordinal(6)] [RED("intensity")] 		public SSimpleCurve Intensity { get; set;}

		[Ordinal(7)] [RED("activatedSkyThreshold")] 		public CBool ActivatedSkyThreshold { get; set;}

		[Ordinal(8)] [RED("skyThreshold")] 		public CFloat SkyThreshold { get; set;}

		[Ordinal(9)] [RED("activatedSkyRange")] 		public CBool ActivatedSkyRange { get; set;}

		[Ordinal(10)] [RED("skyRange")] 		public CFloat SkyRange { get; set;}

		public CEnvDepthOfFieldParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}