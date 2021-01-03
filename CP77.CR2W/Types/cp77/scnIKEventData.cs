using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnIKEventData : CVariable
	{
		[Ordinal(0)]  [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
		[Ordinal(1)]  [RED("chainName")] public CName ChainName { get; set; }
		[Ordinal(2)]  [RED("orientation")] public Quaternion Orientation { get; set; }
		[Ordinal(3)]  [RED("request")] public animIKTargetRequest Request { get; set; }

		public scnIKEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
