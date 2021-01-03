using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ResponseEvent : redEvent
	{
		[Ordinal(0)]  [RED("responseData")] public CHandle<IScriptable> ResponseData { get; set; }

		public ResponseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
