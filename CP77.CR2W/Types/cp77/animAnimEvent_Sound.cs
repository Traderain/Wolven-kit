using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Sound : animAnimEvent
	{
		[Ordinal(0)]  [RED("dontPlayOn")] public CName DontPlayOn { get; set; }
		[Ordinal(1)]  [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(2)]  [RED("metadataContext")] public CName MetadataContext { get; set; }
		[Ordinal(3)]  [RED("onlyPlayOn")] public CName OnlyPlayOn { get; set; }
		[Ordinal(4)]  [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(5)]  [RED("playerGenderAlt")] public CEnum<animAnimEventGenderAlt> PlayerGenderAlt { get; set; }
		[Ordinal(6)]  [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }

		public animAnimEvent_Sound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
