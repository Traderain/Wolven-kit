using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TransparencyAnimationButtonView : BaseButtonView
	{
		[Ordinal(0)]  [RED("AnimationProxies")] public CArray<CHandle<inkanimProxy>> AnimationProxies { get; set; }
		[Ordinal(1)]  [RED("AnimationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(2)]  [RED("DefaultTransparency")] public CFloat DefaultTransparency { get; set; }
		[Ordinal(3)]  [RED("DisabledTransparency")] public CFloat DisabledTransparency { get; set; }
		[Ordinal(4)]  [RED("HoverTransparency")] public CFloat HoverTransparency { get; set; }
		[Ordinal(5)]  [RED("PressTransparency")] public CFloat PressTransparency { get; set; }
		[Ordinal(6)]  [RED("Targets")] public CArray<inkWidgetReference> Targets { get; set; }

		public TransparencyAnimationButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
