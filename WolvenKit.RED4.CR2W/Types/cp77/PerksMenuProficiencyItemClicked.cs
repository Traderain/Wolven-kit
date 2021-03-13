using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		[Ordinal(3)] [RED("index")] public CInt32 Index { get; set; }

		public PerksMenuProficiencyItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
