using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BinkVideoEvent : redEvent
	{
		[Ordinal(0)]  [RED("path")] public redResourceReferenceScriptToken Path { get; set; }
		[Ordinal(1)]  [RED("shouldPlay")] public CBool ShouldPlay { get; set; }
		[Ordinal(2)]  [RED("startingTime")] public CFloat StartingTime { get; set; }

		public BinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
