using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResource : CResource
	{
		[Ordinal(0)]  [RED("animationLibraryResRef")] public raRef<inkanimAnimationLibraryResource> AnimationLibraryResRef { get; set; }
		[Ordinal(1)]  [RED("externalDependenciesForInternalItems")] public CArray<raRef<CResource>> ExternalDependenciesForInternalItems { get; set; }
		[Ordinal(2)]  [RED("externalLibraries")] public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries { get; set; }
		[Ordinal(3)]  [RED("libraryItems")] public CArray<inkWidgetLibraryItem> LibraryItems { get; set; }
		[Ordinal(4)]  [RED("rootDefinitionIndex")] public CUInt32 RootDefinitionIndex { get; set; }
		[Ordinal(5)]  [RED("rootResolution")] public CEnum<inkETextureResolution> RootResolution { get; set; }
		[Ordinal(6)]  [RED("sequences")] public CArray<CHandle<inkanimSequence>> Sequences { get; set; }
		[Ordinal(7)]  [RED("version")] public CEnum<inkWidgetResourceVersion> Version { get; set; }

		public inkWidgetLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
