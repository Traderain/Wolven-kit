using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIRoleCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("role")] public CEnum<EAIRole> Role { get; set; }

		public AIRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
