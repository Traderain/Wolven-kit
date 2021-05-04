using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshAppearance : ISerializable
	{
		private CName _name;
		private CArray<CName> _chunkMaterials;
		private CArray<CName> _tags;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("chunkMaterials")] 
		public CArray<CName> ChunkMaterials
		{
			get => GetProperty(ref _chunkMaterials);
			set => SetProperty(ref _chunkMaterials, value);
		}

		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public meshMeshAppearance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
