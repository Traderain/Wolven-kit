using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
	{
		[Ordinal(0)]  [RED("ints")] public CArray<Vector2> Ints { get; set; }
		[Ordinal(1)]  [RED("roke")] public CFloat Roke { get; set; }

		public vgVectorGraphicShape_PolyLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
