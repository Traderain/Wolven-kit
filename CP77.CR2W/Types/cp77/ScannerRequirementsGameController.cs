using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementsGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("chunkBlackboard")] public CHandle<gameIBlackboard> ChunkBlackboard { get; set; }
		[Ordinal(1)]  [RED("chunkBlackboardDef")] public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef { get; set; }
		[Ordinal(2)]  [RED("questClueBlackboardDef")] public CHandle<UI_ScannerDef> QuestClueBlackboardDef { get; set; }
		[Ordinal(3)]  [RED("ScannerRequirementsRightPanel")] public inkCompoundWidgetReference ScannerRequirementsRightPanel { get; set; }
		[Ordinal(4)]  [RED("requirementsCallbackID")] public CUInt32 RequirementsCallbackID { get; set; }
		[Ordinal(5)]  [RED("isValidRequirements")] public CBool IsValidRequirements { get; set; }
		[Ordinal(6)]  [RED("requirementWidgets")] public CArray<wCHandle<inkWidget>> RequirementWidgets { get; set; }

		public ScannerRequirementsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
