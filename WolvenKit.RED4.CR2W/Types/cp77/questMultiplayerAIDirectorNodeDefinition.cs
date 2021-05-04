using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questMultiplayerAIDirectorParams> _params;

		[Ordinal(2)] 
		[RED("params")] 
		public CHandle<questMultiplayerAIDirectorParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questMultiplayerAIDirectorNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
