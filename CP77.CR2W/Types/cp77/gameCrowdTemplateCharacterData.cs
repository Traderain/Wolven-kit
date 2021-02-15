using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateCharacterData : CVariable
	{
		[Ordinal(0)] [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }

		public gameCrowdTemplateCharacterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
