using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignCustomData : WidgetCustomData
	{
		[Ordinal(0)]  [RED("messege")] public CString Messege { get; set; }
		[Ordinal(1)]  [RED("signShape")] public CEnum<SignShape> SignShape { get; set; }

		public InteractiveSignCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
