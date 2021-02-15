using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkFullscreenCompositionResource : CResource
	{
		[Ordinal(1)] [RED("compositionPresets")] public CArray<inkCompositionPreset> CompositionPresets { get; set; }
		[Ordinal(2)] [RED("previewSettings")] public CHandle<inkCompositionPreviewSettings> PreviewSettings { get; set; }

		public inkFullscreenCompositionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
