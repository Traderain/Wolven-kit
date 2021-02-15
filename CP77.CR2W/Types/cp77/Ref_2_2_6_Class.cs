using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_2_2_6_Class : IScriptable
	{
		[Ordinal(0)] [RED("intProp")] public CInt32 IntProp { get; set; }

		public Ref_2_2_6_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
