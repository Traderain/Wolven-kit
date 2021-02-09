using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BuyItemFromVendor : ActionBool
	{
		[Ordinal(22)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public BuyItemFromVendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
