using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlidingLadder : BaseAnimatedDevice
	{
		[Ordinal(89)]  [RED("offMeshConnectionDown")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionDown { get; set; }
		[Ordinal(90)]  [RED("offMeshConnectionUp")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionUp { get; set; }
		[Ordinal(91)]  [RED("ladderInteraction")] public CHandle<gameinteractionsComponent> LadderInteraction { get; set; }
		[Ordinal(92)]  [RED("wasShot")] public CBool WasShot { get; set; }

		public SlidingLadder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
