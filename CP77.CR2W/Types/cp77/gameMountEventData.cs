using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMountEventData : IScriptable
	{
		[Ordinal(0)]  [RED("entryAnimName")] public CName EntryAnimName { get; set; }
		[Ordinal(1)]  [RED("ignoreHLS")] public CBool IgnoreHLS { get; set; }
		[Ordinal(2)]  [RED("initialTransformLS")] public Transform InitialTransformLS { get; set; }
		[Ordinal(3)]  [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(4)]  [RED("mountEventOptions")] public CHandle<gameMountEventOptions> MountEventOptions { get; set; }
		[Ordinal(5)]  [RED("mountParentEntityId")] public entEntityID MountParentEntityId { get; set; }
		[Ordinal(6)]  [RED("removePitchRollRotationOnDismount")] public CBool RemovePitchRollRotationOnDismount { get; set; }
		[Ordinal(7)]  [RED("setEntityVisibleWhenMountFinish")] public CBool SetEntityVisibleWhenMountFinish { get; set; }
		[Ordinal(8)]  [RED("slotName")] public CName SlotName { get; set; }

		public gameMountEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
