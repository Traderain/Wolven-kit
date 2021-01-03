using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class textWrappingInfo : CVariable
	{
		[Ordinal(0)]  [RED("autoWrappingEnabled")] public CBool AutoWrappingEnabled { get; set; }
		[Ordinal(1)]  [RED("wrappingAtPosition")] public CFloat WrappingAtPosition { get; set; }
		[Ordinal(2)]  [RED("wrappingPolicy")] public CEnum<textWrappingPolicy> WrappingPolicy { get; set; }

		public textWrappingInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
