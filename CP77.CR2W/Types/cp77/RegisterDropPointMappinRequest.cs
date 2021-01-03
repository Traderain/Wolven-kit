using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RegisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)]  [RED("trackingAlternativeMappinID")] public gameNewMappinID TrackingAlternativeMappinID { get; set; }

		public RegisterDropPointMappinRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
