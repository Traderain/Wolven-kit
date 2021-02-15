using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Radio : InteractiveDevice
	{
		[Ordinal(93)] [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(94)] [RED("startingStation")] public CInt32 StartingStation { get; set; }
		[Ordinal(95)] [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(96)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(97)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public Radio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
