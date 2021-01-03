using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("assignOnly")] public CBool AssignOnly { get; set; }
		[Ordinal(1)]  [RED("equipAnimationType")] public CEnum<gameEquipAnimationType> EquipAnimationType { get; set; }
		[Ordinal(2)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public gameDrawItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
