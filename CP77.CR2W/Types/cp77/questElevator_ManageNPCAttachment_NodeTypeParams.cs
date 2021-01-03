using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questElevator_ManageNPCAttachment_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action { get; set; }
		[Ordinal(1)]  [RED("elevatorRef")] public NodeRef ElevatorRef { get; set; }
		[Ordinal(2)]  [RED("npcRef")] public gameEntityReference NpcRef { get; set; }

		public questElevator_ManageNPCAttachment_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
