using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimationSetup : CVariable
	{
		[Ordinal(0)]  [RED("cinematics")] public animAnimSetCollection Cinematics { get; set; }
		[Ordinal(1)]  [RED("finalAnimSetCollection")] public animAnimSetCollection FinalAnimSetCollection { get; set; }
		[Ordinal(2)]  [RED("gameplay")] public animAnimSetCollection Gameplay { get; set; }

		public animAnimationSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
