using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendorUserData : IScriptable
	{
		[Ordinal(0)]  [RED("menu")] public CString Menu { get; set; }
		[Ordinal(1)]  [RED("vendorData")] public CHandle<questVendorPanelData> VendorData { get; set; }

		public VendorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
