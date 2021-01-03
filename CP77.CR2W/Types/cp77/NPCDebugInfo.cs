using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCDebugInfo : CVariable
	{
		[Ordinal(0)]  [RED("characterRecord")] public CHandle<gamedataCharacter_Record> CharacterRecord { get; set; }
		[Ordinal(1)]  [RED("communityName")] public CName CommunityName { get; set; }
		[Ordinal(2)]  [RED("spawnerID")] public entEntityID SpawnerID { get; set; }

		public NPCDebugInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
