using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIGenericEntityLookatTask : AIGenericLookatTask
	{
		[Ordinal(0)]  [RED("activationTimeStamp")] public CFloat ActivationTimeStamp { get; set; }
		[Ordinal(1)]  [RED("lookAtEvent")] public CHandle<entLookAtAddEvent> LookAtEvent { get; set; }
		[Ordinal(2)]  [RED("lookatTarget")] public wCHandle<entEntity> LookatTarget { get; set; }

		public AIGenericEntityLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
