using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)]  [RED("partName_PS4")] public CName PartName_PS4 { get; set; }
		[Ordinal(2)]  [RED("partName_XB1")] public CName PartName_XB1 { get; set; }
		[Ordinal(3)]  [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
		[Ordinal(4)]  [RED("textureAtlas_PS4")] public raRef<inkTextureAtlas> TextureAtlas_PS4 { get; set; }
		[Ordinal(5)]  [RED("textureAtlas_XB1")] public raRef<inkTextureAtlas> TextureAtlas_XB1 { get; set; }

		public inkPlatformSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
