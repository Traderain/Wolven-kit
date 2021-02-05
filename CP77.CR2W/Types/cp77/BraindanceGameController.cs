using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BraindanceGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("currentTimerMarker")] public inkWidgetReference CurrentTimerMarker { get; set; }
		[Ordinal(8)]  [RED("currentTimerText")] public inkTextWidgetReference CurrentTimerText { get; set; }
		[Ordinal(9)]  [RED("activeLayer")] public inkTextWidgetReference ActiveLayer { get; set; }
		[Ordinal(10)]  [RED("layerIcon")] public inkImageWidgetReference LayerIcon { get; set; }
		[Ordinal(11)]  [RED("layerThermalIcon")] public inkImageWidgetReference LayerThermalIcon { get; set; }
		[Ordinal(12)]  [RED("layerVisualIcon")] public inkImageWidgetReference LayerVisualIcon { get; set; }
		[Ordinal(13)]  [RED("layerAudioIcon")] public inkImageWidgetReference LayerAudioIcon { get; set; }
		[Ordinal(14)]  [RED("cursorPoint")] public inkWidgetReference CursorPoint { get; set; }
		[Ordinal(15)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(16)]  [RED("clueHolder")] public CArray<inkCompoundWidgetReference> ClueHolder { get; set; }
		[Ordinal(17)]  [RED("clueBarHolder")] public CArray<inkWidgetReference> ClueBarHolder { get; set; }
		[Ordinal(18)]  [RED("speedIndicatorManagers")] public CArray<inkWidgetReference> SpeedIndicatorManagers { get; set; }
		[Ordinal(19)]  [RED("clueArray")] public CArray<CHandle<BraindanceClueLogicController>> ClueArray { get; set; }
		[Ordinal(20)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(21)]  [RED("barSize")] public CFloat BarSize { get; set; }
		[Ordinal(22)]  [RED("braindanceDuration")] public CFloat BraindanceDuration { get; set; }
		[Ordinal(23)]  [RED("currentTime")] public CFloat CurrentTime { get; set; }
		[Ordinal(24)]  [RED("rootWidget")] public CHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(25)]  [RED("currentLayer")] public CEnum<gameuiEBraindanceLayer> CurrentLayer { get; set; }
		[Ordinal(26)]  [RED("currentSpeed")] public CEnum<scnPlaySpeed> CurrentSpeed { get; set; }
		[Ordinal(27)]  [RED("currentDirection")] public CEnum<scnPlayDirection> CurrentDirection { get; set; }
		[Ordinal(28)]  [RED("startingTimerTopMargin")] public CFloat StartingTimerTopMargin { get; set; }
		[Ordinal(29)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(30)]  [RED("braindanceBB")] public CHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(31)]  [RED("braindanceDef")] public CHandle<BraindanceBlackboardDef> BraindanceDef { get; set; }
		[Ordinal(32)]  [RED("ClueBBID")] public CUInt32 ClueBBID { get; set; }
		[Ordinal(33)]  [RED("VisionModeBBID")] public CUInt32 VisionModeBBID { get; set; }
		[Ordinal(34)]  [RED("ProgressBBID")] public CUInt32 ProgressBBID { get; set; }
		[Ordinal(35)]  [RED("SectionTimeBBID")] public CUInt32 SectionTimeBBID { get; set; }
		[Ordinal(36)]  [RED("IsActiveBBID")] public CUInt32 IsActiveBBID { get; set; }
		[Ordinal(37)]  [RED("EnableExitBBID")] public CUInt32 EnableExitBBID { get; set; }
		[Ordinal(38)]  [RED("IsFPPBBID")] public CUInt32 IsFPPBBID { get; set; }
		[Ordinal(39)]  [RED("PlaybackSpeedID")] public CUInt32 PlaybackSpeedID { get; set; }
		[Ordinal(40)]  [RED("PlaybackDirectionID")] public CUInt32 PlaybackDirectionID { get; set; }
		[Ordinal(41)]  [RED("isFPPMode")] public CBool IsFPPMode { get; set; }
		[Ordinal(42)]  [RED("showTimelineAnimation")] public CHandle<inkanimProxy> ShowTimelineAnimation { get; set; }
		[Ordinal(43)]  [RED("hideTimelineAnimation")] public CHandle<inkanimProxy> HideTimelineAnimation { get; set; }
		[Ordinal(44)]  [RED("showWidgetAnimation")] public CHandle<inkanimProxy> ShowWidgetAnimation { get; set; }

		public BraindanceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
