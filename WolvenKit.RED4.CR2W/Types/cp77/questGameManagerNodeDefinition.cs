using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGameManagerNodeDefinition : questTypedSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIGameManagerNodeType> Type { get; set; }

		public questGameManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
