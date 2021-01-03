using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleSirenDelayEvent : redEvent
	{
		[Ordinal(0)]  [RED("lights")] public CBool Lights { get; set; }
		[Ordinal(1)]  [RED("sounds")] public CBool Sounds { get; set; }

		public VehicleSirenDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
