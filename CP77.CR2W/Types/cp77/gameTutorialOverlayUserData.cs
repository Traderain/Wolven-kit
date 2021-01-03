using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayUserData : inkUserData
	{
		[Ordinal(0)]  [RED("hideOnInput")] public CBool HideOnInput { get; set; }
		[Ordinal(1)]  [RED("overlayId")] public CUInt32 OverlayId { get; set; }

		public gameTutorialOverlayUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
