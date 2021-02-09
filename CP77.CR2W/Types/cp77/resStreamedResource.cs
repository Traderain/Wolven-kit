using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class resStreamedResource : CResource
	{
        //[Ordinal(0)] [RED("resourceVersion")] public CUInt8 resourceVersion { get; set; }

		public resStreamedResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
