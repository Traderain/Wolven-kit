using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleToggleDoorWrapperEvent : redEvent
	{
		private CEnum<vehicleEQuestVehicleDoorState> _action;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleEQuestVehicleDoorState> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		public vehicleToggleDoorWrapperEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
