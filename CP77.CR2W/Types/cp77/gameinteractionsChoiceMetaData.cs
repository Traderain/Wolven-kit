using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceMetaData : CVariable
	{
		[Ordinal(0)]  [RED("tweakDBID")] public TweakDBID TweakDBID { get; set; }
		[Ordinal(1)]  [RED("tweakDBName")] public CString TweakDBName { get; set; }
		[Ordinal(2)]  [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }

		public gameinteractionsChoiceMetaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
