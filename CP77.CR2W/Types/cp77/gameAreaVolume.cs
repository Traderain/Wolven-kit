using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAreaVolume : gameObject
	{
		[Ordinal(0)]  [RED("areaData")] public gameAreaData AreaData { get; set; }

		public gameAreaVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
