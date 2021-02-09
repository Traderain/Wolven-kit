using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseBullet : BaseProjectile
	{
		[Ordinal(41)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(42)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(43)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(44)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(45)]  [RED("alive")] public CBool Alive { get; set; }

		public BaseBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
