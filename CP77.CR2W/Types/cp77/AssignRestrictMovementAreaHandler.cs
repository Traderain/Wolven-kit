using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AssignRestrictMovementAreaHandler : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)]  [RED("resultOnNoChange")] public CEnum<AIbehaviorCompletionStatus> ResultOnNoChange { get; set; }

		public AssignRestrictMovementAreaHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
