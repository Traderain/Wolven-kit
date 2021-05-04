using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateTransitionAbstract : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("m_TransitionOriginStateN")] 		public CName M_TransitionOriginStateN { get; set;}

		[Ordinal(2)] [RED("m_TransitionEndStateN")] 		public CName M_TransitionEndStateN { get; set;}

		public CExplorationStateTransitionAbstract(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}