using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryItem : CVariable
	{
		[Ordinal(0)]  [RED("communityId")] public gameCommunityID CommunityId { get; set; }
		[Ordinal(1)]  [RED("communityIsBackground")] public CBool CommunityIsBackground { get; set; }
		[Ordinal(2)]  [RED("entriesInitialState")] public CArray<worldCommunityEntryInitialState> EntriesInitialState { get; set; }
		[Ordinal(3)]  [RED("template")] public CHandle<communityCommunityTemplateData> Template { get; set; }

		public worldCommunityRegistryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
