using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor : gameEffectNode
	{
		[Ordinal(0)]  [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }

		public gameEffectExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
