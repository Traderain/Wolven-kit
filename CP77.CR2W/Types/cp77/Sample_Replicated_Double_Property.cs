using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Double_Property : CVariable
	{
		[Ordinal(0)]  [RED("property")] public CDouble Property { get; set; }

		public Sample_Replicated_Double_Property(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
