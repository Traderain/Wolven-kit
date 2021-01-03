using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsOpenSpeakerScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("openSpeakerScreen")] public CBool OpenSpeakerScreen { get; set; }
		[Ordinal(1)]  [RED("speakerName")] public CString SpeakerName { get; set; }

		public questFinalBoardsOpenSpeakerScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
