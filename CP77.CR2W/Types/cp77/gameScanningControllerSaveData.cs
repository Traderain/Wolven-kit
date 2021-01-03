using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameScanningControllerSaveData : ISerializable
	{
		[Ordinal(0)]  [RED("taggedObjectIDs")] public CArray<entEntityID> TaggedObjectIDs { get; set; }

		public gameScanningControllerSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
