using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animImportFacialMainPoseDesc : CVariable
	{
		[Ordinal(0)]  [RED("facePart")] public CUInt8 FacePart { get; set; }
		[Ordinal(1)]  [RED("inBetweenScopeMultipliers")] public CArray<CFloat> InBetweenScopeMultipliers { get; set; }
		[Ordinal(2)]  [RED("index")] public CUInt16 Index { get; set; }
		[Ordinal(3)]  [RED("influenceMainWeightIndices")] public CArray<CUInt16> InfluenceMainWeightIndices { get; set; }
		[Ordinal(4)]  [RED("influenceType")] public CUInt8 InfluenceType { get; set; }
		[Ordinal(5)]  [RED("influencedBy")] public CArray<CName> InfluencedBy { get; set; }
		[Ordinal(6)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(7)]  [RED("poseIndices")] public CArray<CUInt16> PoseIndices { get; set; }
		[Ordinal(8)]  [RED("poses")] public CArray<animImportFacialPoseDesc> Poses { get; set; }
		[Ordinal(9)]  [RED("side")] public CUInt8 Side { get; set; }
		[Ordinal(10)]  [RED("weights")] public CArray<CFloat> Weights { get; set; }

		public animImportFacialMainPoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
