using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DropPointRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("holder")] public gamePersistentID Holder { get; set; }
		[Ordinal(1)]  [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(2)]  [RED("status")] public CEnum<DropPointPackageStatus> Status { get; set; }

		public DropPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
