using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_2_3_4_Struct : CVariable
	{
		[Ordinal(0)]  [RED("val")] public CInt32 Val { get; set; }

		public Ref_2_3_4_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
