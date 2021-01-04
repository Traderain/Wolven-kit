using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerBillboard : IParticleDrawer
	{
		[Ordinal(0)]  [RED("isGPUBased")] public CBool IsGPUBased { get; set; }

		public CParticleDrawerBillboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
