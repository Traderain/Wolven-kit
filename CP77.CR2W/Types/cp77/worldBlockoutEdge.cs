using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutEdge : CVariable
	{
		[Ordinal(0)]  [RED("areas", 2)] public CArrayFixedSize<CUInt32> Areas { get; set; }
		[Ordinal(1)]  [RED("isFree")] public CBool IsFree { get; set; }
		[Ordinal(2)]  [RED("points", 2)] public CArrayFixedSize<CUInt32> Points { get; set; }

		public worldBlockoutEdge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
