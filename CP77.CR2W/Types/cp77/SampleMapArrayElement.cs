using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SampleMapArrayElement : CVariable
	{
		[Ordinal(0)]  [RED("myKey")] public CUInt32 MyKey { get; set; }
		[Ordinal(1)]  [RED("someArrayProperty")] public CArray<CString> SomeArrayProperty { get; set; }
		[Ordinal(2)]  [RED("someStringProperty")] public CString SomeStringProperty { get; set; }

		public SampleMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
