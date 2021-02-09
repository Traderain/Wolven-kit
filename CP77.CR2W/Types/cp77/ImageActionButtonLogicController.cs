using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
	{
		[Ordinal(18)]  [RED("tallImageWidget")] public inkImageWidgetReference TallImageWidget { get; set; }
		[Ordinal(19)]  [RED("price")] public CInt32 Price { get; set; }

		public ImageActionButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
