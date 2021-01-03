using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PointerController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("centerButton")] public wCHandle<inkWidget> CenterButton { get; set; }
		[Ordinal(1)]  [RED("centerButtonSlot")] public inkWidgetReference CenterButtonSlot { get; set; }
		[Ordinal(2)]  [RED("connectors")] public CArray<inkWidgetReference> Connectors { get; set; }
		[Ordinal(3)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(4)]  [RED("pointer")] public inkWidgetReference Pointer { get; set; }

		public PointerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
