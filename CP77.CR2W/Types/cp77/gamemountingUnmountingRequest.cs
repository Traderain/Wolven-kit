using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemountingUnmountingRequest : IScriptable
	{
		[Ordinal(0)] [RED("lowLevelMountingInfo")] public gamemountingMountingInfo LowLevelMountingInfo { get; set; }
		[Ordinal(1)] [RED("mountData")] public CHandle<gameMountEventData> MountData { get; set; }

		public gamemountingUnmountingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
