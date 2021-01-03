using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry : CVariable
	{
		[Ordinal(0)]  [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
