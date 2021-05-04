using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAccessPointMiniGameStatus : redEvent
	{
		private CEnum<gameuiHackingMinigameState> _minigameState;

		[Ordinal(0)] 
		[RED("minigameState")] 
		public CEnum<gameuiHackingMinigameState> MinigameState
		{
			get => GetProperty(ref _minigameState);
			set => SetProperty(ref _minigameState, value);
		}

		public gameuiAccessPointMiniGameStatus(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
