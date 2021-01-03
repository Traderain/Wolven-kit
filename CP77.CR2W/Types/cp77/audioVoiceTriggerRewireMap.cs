using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("includes")] public CArray<CName> Includes { get; set; }
		[Ordinal(1)]  [RED("items")] public CArray<audioVoiceTriggerRewireMapItem> Items { get; set; }

		public audioVoiceTriggerRewireMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
