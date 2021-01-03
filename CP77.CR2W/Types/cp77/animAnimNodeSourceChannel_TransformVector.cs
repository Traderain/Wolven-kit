using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_TransformVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)]  [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }

		public animAnimNodeSourceChannel_TransformVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
