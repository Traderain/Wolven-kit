using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RenderProxyCustomData_Mirror : IRenderProxyCustomData
	{

		public RenderProxyCustomData_Mirror(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
