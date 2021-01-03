using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsControllerHit : CVariable
	{
		[Ordinal(0)]  [RED("worldNormal")] public Vector4 WorldNormal { get; set; }
		[Ordinal(1)]  [RED("worldPos")] public Vector4 WorldPos { get; set; }

		public physicsControllerHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
