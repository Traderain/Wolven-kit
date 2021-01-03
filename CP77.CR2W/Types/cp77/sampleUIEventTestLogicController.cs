using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleUIEventTestLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("callbackTextWidgetPath")] public CName CallbackTextWidgetPath { get; set; }
		[Ordinal(1)]  [RED("callbackVerticalPanelPath")] public CName CallbackVerticalPanelPath { get; set; }
		[Ordinal(2)]  [RED("customCallbackName")] public CName CustomCallbackName { get; set; }
		[Ordinal(3)]  [RED("eventTextWidgetPath")] public CName EventTextWidgetPath { get; set; }
		[Ordinal(4)]  [RED("eventVerticalPanelPath")] public CName EventVerticalPanelPath { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(7)]  [RED("verticalPanelWidget")] public wCHandle<inkVerticalPanelWidget> VerticalPanelWidget { get; set; }

		public sampleUIEventTestLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
