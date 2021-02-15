using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("securityLockerProperties")] public SecurityLockerProperties SecurityLockerProperties { get; set; }
		[Ordinal(104)] [RED("isStoringPlayerEquipement")] public CBool IsStoringPlayerEquipement { get; set; }

		public SecurityLockerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
