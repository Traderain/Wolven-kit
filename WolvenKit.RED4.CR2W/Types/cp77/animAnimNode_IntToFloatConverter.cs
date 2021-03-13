using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_IntToFloatConverter : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("inputNode")] public animIntLink InputNode { get; set; }

		public animAnimNode_IntToFloatConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
