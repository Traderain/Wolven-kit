using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTemplateBindingOverride : CVariable
	{
		[Ordinal(0)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)] [RED("propertyName")] public CName PropertyName { get; set; }
		[Ordinal(2)] [RED("binding")] public CHandle<entIBinding> Binding { get; set; }

		public entTemplateBindingOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
