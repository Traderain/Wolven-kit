using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameaudioRagdollSubSystem : gameaudioISoundComponentSubSystem
	{
		[Ordinal(0)]  [RED("customDismembermentSettings")] public CName CustomDismembermentSettings { get; set; }
		[Ordinal(1)]  [RED("defaultMaterialMetadata")] public CName DefaultMaterialMetadata { get; set; }
		[Ordinal(2)]  [RED("lookupMatrixName")] public CName LookupMatrixName { get; set; }

		public gameaudioRagdollSubSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
