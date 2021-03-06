using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariablesList : CVariable
	{
		private CArray<CHandle<LibTreeDefTreeVariable>> _list;

		[Ordinal(0)] 
		[RED("list")] 
		public CArray<CHandle<LibTreeDefTreeVariable>> List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		public LibTreeDefTreeVariablesList(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
