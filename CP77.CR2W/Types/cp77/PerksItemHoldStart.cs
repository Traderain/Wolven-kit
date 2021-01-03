using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerksItemHoldStart : redEvent
	{
		[Ordinal(0)]  [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }
		[Ordinal(1)]  [RED("perkData")] public CHandle<BasePerkDisplayData> PerkData { get; set; }
		[Ordinal(2)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public PerksItemHoldStart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
