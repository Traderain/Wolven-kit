using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_3 : CVariable
	{
		[Ordinal(0)]  [RED("var0")] public CInt32 Var0 { get; set; }

		public Sample_Class_2_3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
