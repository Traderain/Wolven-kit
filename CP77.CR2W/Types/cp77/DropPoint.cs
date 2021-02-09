using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropPoint : BasicDistractionDevice
	{
		[Ordinal(90)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(91)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(92)]  [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(93)]  [RED("inventory")] public CHandle<gameInventory> Inventory { get; set; }

		public DropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
