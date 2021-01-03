using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetDestructionState_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)]  [RED("action")] public CEnum<questSetDestructionStateAction> Action { get; set; }
		[Ordinal(1)]  [RED("params")] public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params { get; set; }

		public questEntityManagerSetDestructionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
