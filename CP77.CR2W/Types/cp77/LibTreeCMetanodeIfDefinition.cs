using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeCMetanodeIfDefinition : LibTreeCMetanodeDefinition
	{
		[Ordinal(0)]  [RED("elseBranch")] public CHandle<LibTreeINodeDefinition> ElseBranch { get; set; }
		[Ordinal(1)]  [RED("ifBranch")] public CHandle<LibTreeINodeDefinition> IfBranch { get; set; }
		[Ordinal(2)]  [RED("ifCondition")] public LibTreeDefBool IfCondition { get; set; }

		public LibTreeCMetanodeIfDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
