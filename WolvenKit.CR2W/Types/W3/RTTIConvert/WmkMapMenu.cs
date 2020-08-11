using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkMapMenu : CObject
	{
		[RED("QUEST_PIN_TYPE_LOW")] 		public CName QUEST_PIN_TYPE_LOW { get; set;}

		[RED("QUEST_PIN_TYPE")] 		public CName QUEST_PIN_TYPE { get; set;}

		[RED("QUEST_PIN_TYPE_HIGH")] 		public CName QUEST_PIN_TYPE_HIGH { get; set;}

		[RED("QUEST_PIN_TYPE_DEADLY")] 		public CName QUEST_PIN_TYPE_DEADLY { get; set;}

		[RED("QUEST_PIN_ROTATION")] 		public CInt32 QUEST_PIN_ROTATION { get; set;}

		[RED("FILTER_LABEL")] 		public CString FILTER_LABEL { get; set;}

		[RED("CACHE_QUEST_PIN_POSITIONS")] 		public CBool CACHE_QUEST_PIN_POSITIONS { get; set;}

		[RED("LOG_ENABLED")] 		public CBool LOG_ENABLED { get; set;}

		[RED("m_thePlayer")] 		public CHandle<CPlayer> M_thePlayer { get; set;}

		[RED("m_commonMapManager")] 		public CHandle<CCommonMapManager> M_commonMapManager { get; set;}

		[RED("m_journalManager")] 		public CHandle<CWitcherJournalManager> M_journalManager { get; set;}

		[RED("m_isNewGamePlus")] 		public CBool M_isNewGamePlus { get; set;}

		[RED("m_cachedQuestMapPins", 2,0)] 		public CArray<WmkQuestMapPin> M_cachedQuestMapPins { get; set;}

		[RED("m_quickUpdateEntityPins")] 		public CBool M_quickUpdateEntityPins { get; set;}

		[RED("m_mapMenu")] 		public CHandle<CR4MapMenu> M_mapMenu { get; set;}

		[RED("m_shownArea")] 		public CEnum<EAreaName> M_shownArea { get; set;}

		[RED("m_questMapPinInstances", 2,0)] 		public CArray<SCommonMapPinInstance> M_questMapPinInstances { get; set;}

		[RED("m_questMapPins", 2,0)] 		public CArray<WmkQuestMapPin> M_questMapPins { get; set;}

		[RED("m_currentTrackedQuest")] 		public CHandle<CJournalQuest> M_currentTrackedQuest { get; set;}

		[RED("m_currentHighlightedObjective")] 		public CHandle<CJournalQuestObjective> M_currentHighlightedObjective { get; set;}

		public WmkMapMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WmkMapMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}