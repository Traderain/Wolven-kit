using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair : ModuleInstance
	{
		[Ordinal(0)]  [RED("isLookedAt")] public CBool IsLookedAt { get; set; }
		[Ordinal(1)]  [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(2)]  [RED("wasProcessed")] public CBool WasProcessed { get; set; }
		[Ordinal(3)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<InstanceState> State { get; set; }
		[Ordinal(5)]  [RED("previousInstance")] public CHandle<ModuleInstance> PreviousInstance { get; set; }

		public Crosshair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
