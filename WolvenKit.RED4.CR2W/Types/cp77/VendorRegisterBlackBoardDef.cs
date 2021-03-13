using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorRegisterBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("vendors")] public gamebbScriptID_Variant Vendors { get; set; }

		public VendorRegisterBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
