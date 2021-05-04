using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequipItemsRequest : gamePlayerScriptableSystemRequest
	{
		private CArray<gameItemID> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameItemID> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public UnequipItemsRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
