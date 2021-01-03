using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleComponentsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("components")] public CArray<SComponentOperationData> Components { get; set; }

		public ToggleComponentsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
