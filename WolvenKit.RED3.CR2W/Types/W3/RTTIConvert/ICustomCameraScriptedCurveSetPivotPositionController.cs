using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ICustomCameraScriptedCurveSetPivotPositionController : ICustomCameraScriptedPivotPositionController
	{
		[Ordinal(1)] [RED("curveSet", 2,0)] 		public CArray<CPtr<CCurve>> CurveSet { get; set;}

		[Ordinal(2)] [RED("curveNames", 2,0)] 		public CArray<CName> CurveNames { get; set;}

		public ICustomCameraScriptedCurveSetPivotPositionController(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}