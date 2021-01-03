using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSceneReturn_ConditionType : questISceneConditionType
	{
		[Ordinal(0)]  [RED("returnConditions")] public CArray<CHandle<scnIReturnCondition>> ReturnConditions { get; set; }
		[Ordinal(1)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public questSceneReturn_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
