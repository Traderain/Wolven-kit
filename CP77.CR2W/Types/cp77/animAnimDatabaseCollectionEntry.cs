using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimDatabaseCollectionEntry : CVariable
	{
		[Ordinal(0)]  [RED("animDatabase")] public rRef<C2dArray> AnimDatabase { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("overrideAnimDatabase")] public rRef<animGenericAnimDatabase> OverrideAnimDatabase { get; set; }

		public animAnimDatabaseCollectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
