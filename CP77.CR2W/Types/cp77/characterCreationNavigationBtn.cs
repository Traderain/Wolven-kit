using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class characterCreationNavigationBtn : inkButtonController
	{
		[Ordinal(0)]  [RED("icon1")] public inkWidgetReference Icon1 { get; set; }
		[Ordinal(1)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(2)]  [RED("shouldPlaySoundOnHover")] public CBool ShouldPlaySoundOnHover { get; set; }

		public characterCreationNavigationBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
