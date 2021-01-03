using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCPredicateDefinition : CVariable
	{
		[Ordinal(0)]  [RED("binaryOperator")] public CEnum<gameinteractionsEBinaryOperator> BinaryOperator { get; set; }
		[Ordinal(1)]  [RED("functor1DataDefinition")] public CHandle<gameinteractionsCFunctorDefinition> Functor1DataDefinition { get; set; }
		[Ordinal(2)]  [RED("functor2DataDefinition")] public CHandle<gameinteractionsCFunctorDefinition> Functor2DataDefinition { get; set; }
		[Ordinal(3)]  [RED("predicateType")] public CHandle<gameinteractionsIPredicateType> PredicateType { get; set; }

		public gameinteractionsCPredicateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
