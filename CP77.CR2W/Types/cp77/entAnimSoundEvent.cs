using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAnimSoundEvent : entSoundEvent
	{
		[Ordinal(0)]  [RED("metadataContext")] public CName MetadataContext { get; set; }

		public entAnimSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
