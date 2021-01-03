using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionVector : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }

		public animAnimNode_MathExpressionVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
