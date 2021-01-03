using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EvaluateGameplayRoleEvent : redEvent
	{
		[Ordinal(0)]  [RED("force")] public CBool Force { get; set; }

		public EvaluateGameplayRoleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
