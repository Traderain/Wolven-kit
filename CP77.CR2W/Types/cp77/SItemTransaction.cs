using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SItemTransaction : CVariable
	{
		[Ordinal(0)]  [RED("itemStack")] public gameSItemStack ItemStack { get; set; }
		[Ordinal(1)]  [RED("pricePerItem")] public CInt32 PricePerItem { get; set; }

		public SItemTransaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
