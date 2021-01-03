using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkInkGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("appliedViruses")] public CArray<CEnum<ExtraEffect>> AppliedViruses { get; set; }
		[Ordinal(1)]  [RED("basicAccessCompletion")] public ProgramProgressData BasicAccessCompletion { get; set; }
		[Ordinal(2)]  [RED("bufferElements")] public CArray<ElementData> BufferElements { get; set; }
		[Ordinal(3)]  [RED("completedPrograms")] public CArray<CString> CompletedPrograms { get; set; }
		[Ordinal(4)]  [RED("completedProgramsPD")] public CArray<ProgramData> CompletedProgramsPD { get; set; }
		[Ordinal(5)]  [RED("dimension")] public CInt32 Dimension { get; set; }
		[Ordinal(6)]  [RED("endGame")] public CBool EndGame { get; set; }
		[Ordinal(7)]  [RED("enemyBufferElements")] public CArray<ElementData> EnemyBufferElements { get; set; }
		[Ordinal(8)]  [RED("enemyCompletedPrograms")] public CArray<CString> EnemyCompletedPrograms { get; set; }
		[Ordinal(9)]  [RED("enemyCompletedProgramsPD")] public CArray<ProgramData> EnemyCompletedProgramsPD { get; set; }
		[Ordinal(10)]  [RED("enemyProgramsCompletion")] public CArray<ProgramProgressData> EnemyProgramsCompletion { get; set; }
		[Ordinal(11)]  [RED("initRound")] public CBool InitRound { get; set; }
		[Ordinal(12)]  [RED("miniGameRecord")] public wCHandle<gamedataHackingMiniGame_Record> MiniGameRecord { get; set; }
		[Ordinal(13)]  [RED("networkData")] public NetworkMinigameData NetworkData { get; set; }
		[Ordinal(14)]  [RED("officerBreach")] public CBool OfficerBreach { get; set; }
		[Ordinal(15)]  [RED("oldPickX")] public CInt32 OldPickX { get; set; }
		[Ordinal(16)]  [RED("oldPickY")] public CInt32 OldPickY { get; set; }
		[Ordinal(17)]  [RED("onBreachingNetworkListener")] public CUInt32 OnBreachingNetworkListener { get; set; }
		[Ordinal(18)]  [RED("onDevicesCountChangedListener")] public CUInt32 OnDevicesCountChangedListener { get; set; }
		[Ordinal(19)]  [RED("pickX")] public CInt32 PickX { get; set; }
		[Ordinal(20)]  [RED("pickY")] public CInt32 PickY { get; set; }
		[Ordinal(21)]  [RED("playerProgramsCompletion")] public CArray<ProgramProgressData> PlayerProgramsCompletion { get; set; }
		[Ordinal(22)]  [RED("regenGrid")] public CBool RegenGrid { get; set; }
		[Ordinal(23)]  [RED("steps")] public CInt32 Steps { get; set; }
		[Ordinal(24)]  [RED("symbolProbabilities")] public CArray<CInt32> SymbolProbabilities { get; set; }
		[Ordinal(25)]  [RED("symbols")] public CArray<CString> Symbols { get; set; }
		[Ordinal(26)]  [RED("trapsDelayed")] public CArray<CString> TrapsDelayed { get; set; }
		[Ordinal(27)]  [RED("turn")] public CString Turn { get; set; }
		[Ordinal(28)]  [RED("visualController")] public wCHandle<NetworkMinigameVisualController> VisualController { get; set; }

		public NetworkInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
