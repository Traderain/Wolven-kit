using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("overArrow")] public inkWidgetReference OverArrow { get; set; }

		public characterCreationBodyMorphOptionSelectorButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
