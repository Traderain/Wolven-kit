using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		[Ordinal(1)]  [RED("textRoot")] public inkWidgetReference TextRoot { get; set; }
		[Ordinal(2)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(3)]  [RED("animSelectionBackground")] public CHandle<inkanimProxy> AnimSelectionBackground { get; set; }
		[Ordinal(4)]  [RED("animSelectionText")] public CHandle<inkanimProxy> AnimSelectionText { get; set; }
		[Ordinal(5)]  [RED("selectedState")] public CBool SelectedState { get; set; }
		[Ordinal(6)]  [RED("animationDuration")] public CFloat AnimationDuration { get; set; }

		public MessangerReplyItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
