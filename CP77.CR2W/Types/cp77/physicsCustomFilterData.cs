using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsCustomFilterData : ISerializable
	{
		[Ordinal(0)]  [RED("collideWith")] public CArray<CName> CollideWith { get; set; }
		[Ordinal(1)]  [RED("collisionType")] public CArray<CName> CollisionType { get; set; }
		[Ordinal(2)]  [RED("queryDetect")] public CArray<CName> QueryDetect { get; set; }

		public physicsCustomFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
