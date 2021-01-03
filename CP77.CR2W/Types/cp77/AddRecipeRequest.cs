using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("hideOnItemsAdded")] public CArray<wCHandle<gamedataItem_Record>> HideOnItemsAdded { get; set; }
		[Ordinal(2)]  [RED("recipe")] public TweakDBID Recipe { get; set; }

		public AddRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
