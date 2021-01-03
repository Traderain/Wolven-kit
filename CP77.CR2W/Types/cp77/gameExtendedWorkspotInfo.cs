using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameExtendedWorkspotInfo : IScriptable
	{
		[Ordinal(0)]  [RED("entering")] public CBool Entering { get; set; }
		[Ordinal(1)]  [RED("exiting")] public CBool Exiting { get; set; }
		[Ordinal(2)]  [RED("inMotion")] public CBool InMotion { get; set; }
		[Ordinal(3)]  [RED("inReaction")] public CBool InReaction { get; set; }
		[Ordinal(4)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(5)]  [RED("playingSyncAnim")] public CBool PlayingSyncAnim { get; set; }

		public gameExtendedWorkspotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
