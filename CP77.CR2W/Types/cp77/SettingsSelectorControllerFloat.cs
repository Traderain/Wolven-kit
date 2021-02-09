using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerFloat : SettingsSelectorControllerRange
	{
		[Ordinal(18)]  [RED("newValue")] public CFloat NewValue { get; set; }
		[Ordinal(19)]  [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }
		[Ordinal(20)]  [RED("sliderController")] public wCHandle<inkSliderController> SliderController { get; set; }

		public SettingsSelectorControllerFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
