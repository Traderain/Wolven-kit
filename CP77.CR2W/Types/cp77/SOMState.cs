using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SOMState : CVariable
	{
		[Ordinal(0)]  [RED("blendModeDesc")] public PSODescBlendModeDesc BlendModeDesc { get; set; }
		[Ordinal(1)]  [RED("depthStencilModeDesc")] public PSODescDepthStencilModeDesc DepthStencilModeDesc { get; set; }
		[Ordinal(2)]  [RED("rasterizerModeDesc")] public PSODescRasterizerModeDesc RasterizerModeDesc { get; set; }
		[Ordinal(3)]  [RED("stencilReadMask")] public CUInt8 StencilReadMask { get; set; }
		[Ordinal(4)]  [RED("stencilRef")] public CUInt8 StencilRef { get; set; }
		[Ordinal(5)]  [RED("stencilWriteMask")] public CUInt8 StencilWriteMask { get; set; }

		public SOMState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
