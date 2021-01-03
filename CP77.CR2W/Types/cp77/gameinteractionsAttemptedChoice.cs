using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsAttemptedChoice : CVariable
	{
		[Ordinal(0)]  [RED("choice")] public gameinteractionsChoice Choice { get; set; }
		[Ordinal(1)]  [RED("choiceIdx")] public CInt32 ChoiceIdx { get; set; }
		[Ordinal(2)]  [RED("isSuccess")] public CBool IsSuccess { get; set; }
		[Ordinal(3)]  [RED("visualizerType")] public CEnum<gameinteractionsvisEVisualizerType> VisualizerType { get; set; }

		public gameinteractionsAttemptedChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
