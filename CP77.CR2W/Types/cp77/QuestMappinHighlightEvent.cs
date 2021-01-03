using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestMappinHighlightEvent : redEvent
	{
		[Ordinal(0)]  [RED("hash")] public CUInt32 Hash { get; set; }

		public QuestMappinHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
