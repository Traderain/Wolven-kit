using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldWorldListResourceEntry : CVariable
	{
		[Ordinal(0)]  [RED("streamingWorld")] public raRef<CResource> StreamingWorld { get; set; }
		[Ordinal(1)]  [RED("world")] public raRef<CResource> World { get; set; }
		[Ordinal(2)]  [RED("worldName")] public CString WorldName { get; set; }

		public worldWorldListResourceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
