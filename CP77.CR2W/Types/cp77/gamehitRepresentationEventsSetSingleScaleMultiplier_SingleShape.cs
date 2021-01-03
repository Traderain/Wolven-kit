using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		[Ordinal(0)]  [RED("shapeName")] public CName ShapeName { get; set; }

		public gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
