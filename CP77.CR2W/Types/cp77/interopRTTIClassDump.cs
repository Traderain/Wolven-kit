using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDump : CVariable
	{
		[Ordinal(0)]  [RED("classNames")] public CArray<CString> ClassNames { get; set; }
		[Ordinal(1)]  [RED("descriptiveNames")] public CArray<CString> DescriptiveNames { get; set; }
		[Ordinal(2)]  [RED("entries")] public CArray<interopRTTIClassDumpEntry> Entries { get; set; }
		[Ordinal(3)]  [RED("resourceInfos")] public CArray<interopRTTIResourceDumpInfo> ResourceInfos { get; set; }

		public interopRTTIClassDump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
