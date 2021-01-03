using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("False")] public animPoseLink False { get; set; }
		[Ordinal(1)]  [RED("True")] public animPoseLink True { get; set; }
		[Ordinal(2)]  [RED("condition")] public CHandle<animIRuntimeCondition> Condition { get; set; }

		public animAnimNode_RuntimeSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
