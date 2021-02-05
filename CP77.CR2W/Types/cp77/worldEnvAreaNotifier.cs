using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEnvAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(0)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(1)]  [RED("horizontalFadeDistance")] public CFloat HorizontalFadeDistance { get; set; }
		[Ordinal(2)]  [RED("verticalFadeDistance")] public CFloat VerticalFadeDistance { get; set; }
		[Ordinal(3)]  [RED("blendTimeIn")] public CFloat BlendTimeIn { get; set; }
		[Ordinal(4)]  [RED("blendTimeOut")] public CFloat BlendTimeOut { get; set; }
		[Ordinal(5)]  [RED("env")] public rRef<worldEnvironmentAreaParameters> Env { get; set; }
		[Ordinal(6)]  [RED("params")] public WorldRenderAreaSettings Params { get; set; }
		[Ordinal(7)]  [RED("weatherStateNames")] public CArray<CName> WeatherStateNames { get; set; }
		[Ordinal(8)]  [RED("weatherStateValues")] public CArray<CBool> WeatherStateValues { get; set; }

		public worldEnvAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
