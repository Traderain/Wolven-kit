using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureFeatures : CVariable
	{
		[Ordinal(0)]  [RED("allowOcclusionCulling")] public CBool AllowOcclusionCulling { get; set; }
		[Ordinal(1)]  [RED("antiAliasing")] public CBool AntiAliasing { get; set; }
		[Ordinal(2)]  [RED("contactShadows")] public CBool ContactShadows { get; set; }
		[Ordinal(3)]  [RED("localShadows")] public CBool LocalShadows { get; set; }
		[Ordinal(4)]  [RED("renderDecals")] public CBool RenderDecals { get; set; }
		[Ordinal(5)]  [RED("renderForwardNoTXAA")] public CBool RenderForwardNoTXAA { get; set; }
		[Ordinal(6)]  [RED("renderParticles")] public CBool RenderParticles { get; set; }

		public entRenderToTextureFeatures(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
