using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FrozenFrame : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("clearEventName")] public CName ClearEventName { get; set; }
		[Ordinal(1)]  [RED("maxFramesFrozen")] public CInt32 MaxFramesFrozen { get; set; }
		[Ordinal(2)]  [RED("triggerEventName")] public CName TriggerEventName { get; set; }

		public animAnimNode_FrozenFrame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
