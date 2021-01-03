using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)]  [RED("params")] public CArray<CHandle<questDeviceManager_NodeTypeParams>> Params { get; set; }

		public questDeviceManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
