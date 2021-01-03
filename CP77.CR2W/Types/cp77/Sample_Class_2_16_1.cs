using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_16_1 : CVariable
	{
		[Ordinal(0)]  [RED("ArrayOfInts")] public CArray<CInt32> ArrayOfInts { get; set; }
		[Ordinal(1)]  [RED("MyNameForVariable")] public CHandle<Sample_Class_2_16_0> MyNameForVariable { get; set; }

		public Sample_Class_2_16_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
