using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AreaTypeTransition : CVariable
	{
		[Ordinal(0)]  [RED("listenerID")] public CUInt32 ListenerID { get; set; }
		[Ordinal(1)]  [RED("transitionHour")] public CInt32 TransitionHour { get; set; }
		[Ordinal(2)]  [RED("transitionMode")] public CEnum<ETransitionMode> TransitionMode { get; set; }
		[Ordinal(3)]  [RED("transitionTo")] public CEnum<ESecurityAreaType> TransitionTo { get; set; }

		public AreaTypeTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
