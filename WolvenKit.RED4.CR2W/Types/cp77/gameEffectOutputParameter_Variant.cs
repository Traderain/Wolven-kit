using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectOutputParameter_Variant : CVariable
	{
		[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }

		public gameEffectOutputParameter_Variant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
