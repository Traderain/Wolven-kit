using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)]  [RED("subtype")] public CHandle<questICharacterManagerParameters_NodeSubType> Subtype { get; set; }

		public questCharacterManagerParameters_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
