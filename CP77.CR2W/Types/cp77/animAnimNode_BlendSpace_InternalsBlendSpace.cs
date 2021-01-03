using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpace : CVariable
	{
		[Ordinal(0)]  [RED("animEndEventName")] public CName AnimEndEventName { get; set; }
		[Ordinal(1)]  [RED("boundaryPointsCount")] public CUInt32 BoundaryPointsCount { get; set; }
		[Ordinal(2)]  [RED("cachedSamplesForGridPoints_simplexIndex")] public CArray<CInt32> CachedSamplesForGridPoints_simplexIndex { get; set; }
		[Ordinal(3)]  [RED("cachedSamplesForGridPoints_weightsForPoints")] public CArray<CFloat> CachedSamplesForGridPoints_weightsForPoints { get; set; }
		[Ordinal(4)]  [RED("cachedSpacePoints_coordinates")] public CArray<CFloat> CachedSpacePoints_coordinates { get; set; }
		[Ordinal(5)]  [RED("cachedSpaceSimplexes_pointsIndices")] public CArray<CUInt32> CachedSpaceSimplexes_pointsIndices { get; set; }
		[Ordinal(6)]  [RED("coordinatesDescriptions")] public CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> CoordinatesDescriptions { get; set; }
		[Ordinal(7)]  [RED("fireAnimEndEvent")] public CBool FireAnimEndEvent { get; set; }
		[Ordinal(8)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(9)]  [RED("needsRuntimeTriangulation")] public CBool NeedsRuntimeTriangulation { get; set; }
		[Ordinal(10)]  [RED("spaceDimension")] public CUInt32 SpaceDimension { get; set; }
		[Ordinal(11)]  [RED("spacePoints")] public CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> SpacePoints { get; set; }
		[Ordinal(12)]  [RED("wasRuntimeTriangulationResaveDone")] public CBool WasRuntimeTriangulationResaveDone { get; set; }

		public animAnimNode_BlendSpace_InternalsBlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
