using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SmartHouseConfiguration : CVariable
	{
		[Ordinal(0)]  [RED("enableInteraction")] public CBool EnableInteraction { get; set; }
		[Ordinal(1)]  [RED("factName")] public CName FactName { get; set; }

		public SmartHouseConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
