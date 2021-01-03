using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedeviceDataElement : CVariable
	{
		[Ordinal(0)]  [RED("content")] public CString Content { get; set; }
		[Ordinal(1)]  [RED("date")] public CString Date { get; set; }
		[Ordinal(2)]  [RED("documentName")] public CName DocumentName { get; set; }
		[Ordinal(3)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(4)]  [RED("isEncrypted")] public CBool IsEncrypted { get; set; }
		[Ordinal(5)]  [RED("journalPath")] public CHandle<gameJournalPath> JournalPath { get; set; }
		[Ordinal(6)]  [RED("owner")] public CString Owner { get; set; }
		[Ordinal(7)]  [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }
		[Ordinal(8)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(9)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(10)]  [RED("wasRead")] public CBool WasRead { get; set; }

		public gamedeviceDataElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
