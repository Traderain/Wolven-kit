using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class appearanceCensorshipEntry : CVariable
	{
		[Ordinal(0)]  [RED("CensorFlags")] public CUInt32 CensorFlags { get; set; }
		[Ordinal(1)]  [RED("Censored")] public CName Censored { get; set; }
		[Ordinal(2)]  [RED("Original")] public CName Original { get; set; }

		public appearanceCensorshipEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
