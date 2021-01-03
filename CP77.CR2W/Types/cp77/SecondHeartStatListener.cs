using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecondHeartStatListener : gameScriptStatsListener
	{
		[Ordinal(0)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }

		public SecondHeartStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
