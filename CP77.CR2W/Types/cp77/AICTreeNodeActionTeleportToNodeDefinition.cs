using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(0)]  [RED("doNavTest")] public CBool DoNavTest { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public LibTreeDefNodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("offset")] public LibTreeDefVector Offset { get; set; }

		public AICTreeNodeActionTeleportToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
