using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GuardbreakReactionTask : AIHitReactionTask
	{
		[Ordinal(0)]  [RED("tweakDBPackage")] public TweakDBID TweakDBPackage { get; set; }

		public GuardbreakReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
