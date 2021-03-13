using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionCustomActionType : audioAudioMetadata
	{
		[Ordinal(1)] [RED("void")] public CBool Void { get; set; }

		public audioLocomotionCustomActionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
