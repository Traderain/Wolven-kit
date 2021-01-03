using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_NewEffect_Ricochet : gameEffectPostAction
	{
		[Ordinal(0)]  [RED("childEffect")] public CBool ChildEffect { get; set; }
		[Ordinal(1)]  [RED("childEffectTag")] public CName ChildEffectTag { get; set; }
		[Ordinal(2)]  [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
		[Ordinal(3)]  [RED("tagInThisFile")] public CName TagInThisFile { get; set; }

		public gameEffectAction_NewEffect_Ricochet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
