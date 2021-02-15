using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workSyncAnimClip : workAnimClip
	{
		[Ordinal(4)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)] [RED("syncOffset")] public Transform SyncOffset { get; set; }

		public workSyncAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
