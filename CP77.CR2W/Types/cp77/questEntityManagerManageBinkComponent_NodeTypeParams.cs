using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerManageBinkComponent_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CEnum<gameBinkVideoAction> Action { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(2)]  [RED("videoPath")] public CString VideoPath { get; set; }

		public questEntityManagerManageBinkComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
