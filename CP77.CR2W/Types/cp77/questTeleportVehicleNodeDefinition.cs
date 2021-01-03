using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)]  [RED("params")] public questTeleportPuppetParams Params { get; set; }
		[Ordinal(2)]  [RED("resetVelocities")] public CBool ResetVelocities { get; set; }

		public questTeleportVehicleNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
