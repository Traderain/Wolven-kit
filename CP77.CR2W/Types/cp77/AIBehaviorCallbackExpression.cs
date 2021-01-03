using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIBehaviorCallbackExpression : AIbehaviorexpressionScript
	{
		[Ordinal(0)]  [RED("callbackAction")] public CEnum<ECallbackExpressionActions> CallbackAction { get; set; }
		[Ordinal(1)]  [RED("callbackId")] public CUInt32 CallbackId { get; set; }
		[Ordinal(2)]  [RED("callbackName")] public CName CallbackName { get; set; }
		[Ordinal(3)]  [RED("initialValue")] public CBool InitialValue { get; set; }
		[Ordinal(4)]  [RED("value")] public CBool Value { get; set; }

		public AIBehaviorCallbackExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
