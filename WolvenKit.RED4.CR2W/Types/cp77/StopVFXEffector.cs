using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopVFXEffector : gameEffector
	{
		[Ordinal(0)] [RED("vfxName")] public CName VfxName { get; set; }
		[Ordinal(1)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public StopVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
