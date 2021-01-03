using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameInventoryItemAbility : CVariable
	{
		[Ordinal(0)]  [RED("Description")] public CString Description { get; set; }
		[Ordinal(1)]  [RED("IconPath")] public CName IconPath { get; set; }
		[Ordinal(2)]  [RED("LocalizationDataPackage")] public CHandle<gameUILocalizationDataPackage> LocalizationDataPackage { get; set; }
		[Ordinal(3)]  [RED("Title")] public CString Title { get; set; }

		public gameInventoryItemAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
