using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BlackBoardRequestEvent : redEvent
	{
		[Ordinal(0)]  [RED("blackBoard")] public CHandle<gameIBlackboard> BlackBoard { get; set; }
		[Ordinal(1)]  [RED("entryTag")] public CName EntryTag { get; set; }
		[Ordinal(2)]  [RED("storageClass")] public CEnum<gameScriptedBlackboardStorage> StorageClass { get; set; }

		public BlackBoardRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
