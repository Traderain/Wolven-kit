using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuHubLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("menuObject")] public inkWidgetReference MenuObject { get; set; }
		[Ordinal(1)]  [RED("btnCrafting")] public inkWidgetReference BtnCrafting { get; set; }
		[Ordinal(2)]  [RED("btnPerks")] public inkWidgetReference BtnPerks { get; set; }
		[Ordinal(3)]  [RED("btnStats")] public inkWidgetReference BtnStats { get; set; }
		[Ordinal(4)]  [RED("btnInventory")] public inkWidgetReference BtnInventory { get; set; }
		[Ordinal(5)]  [RED("btnBackpack")] public inkWidgetReference BtnBackpack { get; set; }
		[Ordinal(6)]  [RED("btnCyberware")] public inkWidgetReference BtnCyberware { get; set; }
		[Ordinal(7)]  [RED("btnMap")] public inkWidgetReference BtnMap { get; set; }
		[Ordinal(8)]  [RED("btnJournal")] public inkWidgetReference BtnJournal { get; set; }
		[Ordinal(9)]  [RED("btnPhone")] public inkWidgetReference BtnPhone { get; set; }
		[Ordinal(10)]  [RED("btnTarot")] public inkWidgetReference BtnTarot { get; set; }
		[Ordinal(11)]  [RED("btnShard")] public inkWidgetReference BtnShard { get; set; }
		[Ordinal(12)]  [RED("btnCodex")] public inkWidgetReference BtnCodex { get; set; }
		[Ordinal(13)]  [RED("panelInventory")] public inkWidgetReference PanelInventory { get; set; }
		[Ordinal(14)]  [RED("panelJournal")] public inkWidgetReference PanelJournal { get; set; }
		[Ordinal(15)]  [RED("panelCharacter")] public inkWidgetReference PanelCharacter { get; set; }
		[Ordinal(16)]  [RED("menusData")] public CHandle<MenuDataBuilder> MenusData { get; set; }
		[Ordinal(17)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(18)]  [RED("tooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }

		public MenuHubLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
