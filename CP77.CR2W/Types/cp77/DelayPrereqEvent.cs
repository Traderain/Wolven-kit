using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayPrereqEvent : redEvent
	{
		[Ordinal(0)]  [RED("state")] public CHandle<GameTimePrereqState> State { get; set; }

		public DelayPrereqEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
