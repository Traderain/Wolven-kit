using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePlayerCoverStatusChangedEvent : redEvent
	{
		[Ordinal(0)]  [RED("direction")] public CEnum<gamePlayerCoverDirection> Direction { get; set; }
		[Ordinal(1)]  [RED("fullyBehindCover")] public CBool FullyBehindCover { get; set; }

		public gamePlayerCoverStatusChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
