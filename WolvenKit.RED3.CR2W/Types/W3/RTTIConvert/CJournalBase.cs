using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalBase : CObject
	{
		[Ordinal(1)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(2)] [RED("baseName")] 		public CString BaseName { get; set;}

		[Ordinal(3)] [RED("order")] 		public CUInt32 Order { get; set;}

		[Ordinal(4)] [RED("uniqueScriptIdentifier")] 		public CName UniqueScriptIdentifier { get; set;}

		public CJournalBase(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}