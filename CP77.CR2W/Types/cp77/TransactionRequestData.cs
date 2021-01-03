using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TransactionRequestData : CVariable
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("powerLevel")] public CFloat PowerLevel { get; set; }
		[Ordinal(2)]  [RED("quantity")] public CInt32 Quantity { get; set; }

		public TransactionRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
