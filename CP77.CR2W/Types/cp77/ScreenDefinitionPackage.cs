using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScreenDefinitionPackage : CVariable
	{
		[Ordinal(0)]  [RED("screenDefinition")] public CHandle<gamedataDeviceUIDefinition_Record> ScreenDefinition { get; set; }
		[Ordinal(1)]  [RED("style")] public CHandle<gamedataWidgetStyle_Record> Style { get; set; }

		public ScreenDefinitionPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
