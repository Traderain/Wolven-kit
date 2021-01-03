using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAmmoData : CVariable
	{
		[Ordinal(0)]  [RED("available")] public CInt32 Available { get; set; }
		[Ordinal(1)]  [RED("equipped")] public CInt32 Equipped { get; set; }
		[Ordinal(2)]  [RED("id")] public gameItemID Id { get; set; }

		public gameAmmoData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
