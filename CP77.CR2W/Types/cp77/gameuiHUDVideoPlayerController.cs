using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("playOnHud")] public CBool PlayOnHud { get; set; }

		public gameuiHUDVideoPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
