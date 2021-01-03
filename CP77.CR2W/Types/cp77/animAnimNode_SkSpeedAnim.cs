using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSpeedAnim : animAnimNode_SkAnim
	{
		[Ordinal(0)]  [RED("Speed")] public animFloatLink Speed { get; set; }

		public animAnimNode_SkSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
