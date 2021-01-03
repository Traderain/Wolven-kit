using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("DismEffects")] public CArray<CHandle<entdismembermentEffectResource>> DismEffects { get; set; }
		[Ordinal(1)]  [RED("DismWoundConfig")] public entdismembermentWoundsConfigSet DismWoundConfig { get; set; }
		[Ordinal(2)]  [RED("Wounds")] public CArray<CHandle<entdismembermentWoundResource>> Wounds { get; set; }
		[Ordinal(3)]  [RED("appearances")] public CArray<CHandle<appearanceAppearanceDefinition>> Appearances { get; set; }
		[Ordinal(4)]  [RED("baseEntity")] public raRef<entEntityTemplate> BaseEntity { get; set; }
		[Ordinal(5)]  [RED("baseEntityType")] public CName BaseEntityType { get; set; }
		[Ordinal(6)]  [RED("baseType")] public CName BaseType { get; set; }
		[Ordinal(7)]  [RED("censorshipMapping")] public CArray<appearanceCensorshipEntry> CensorshipMapping { get; set; }
		[Ordinal(8)]  [RED("commonCookData")] public raRef<appearanceCookedAppearanceData> CommonCookData { get; set; }
		[Ordinal(9)]  [RED("forceCompileProxy")] public CBool ForceCompileProxy { get; set; }
		[Ordinal(10)]  [RED("partType")] public CName PartType { get; set; }
		[Ordinal(11)]  [RED("preset")] public CName Preset { get; set; }
		[Ordinal(12)]  [RED("proxyPolyCount")] public CInt32 ProxyPolyCount { get; set; }

		public appearanceAppearanceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
