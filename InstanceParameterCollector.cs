using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using HotGearAllInOne;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

[Transaction()]
[Regeneration()]
public class InstanceParameterCollector
{
	public virtual Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		GlobalVar.G_commandData = commandData;
		UIApplication application = commandData.get_Application();
		Document document = application.get_ActiveUIDocument().get_Document();
		UIDocument activeUIDocument = application.get_ActiveUIDocument();
		Application application2 = commandData.get_Application().get_Application();
		View activeView = document.get_ActiveView();
		GlobalVar.TypeORInstance = "Family Instance";
		Selection selection = application.get_ActiveUIDocument().get_Selection();
		ICollection<ElementId> elementIds = selection.GetElementIds();
		List<Element> list = new List<Element>();
		foreach (ElementId item in elementIds)
		{
			Element element = document.GetElement(item);
			list.Add(element);
		}
		if (list.Count > 0)
		{
			DataSet dataSet = new DataSet();
			DataSet dataSet2 = new DataSet();
			List<ElementId> list2 = new List<ElementId>();
			foreach (Element item2 in list)
			{
				try
				{
					list2.Add(item2.get_Category().get_Id());
				}
				catch
				{
					MessageBox.Show("None Category Instance Is Not Support.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			List<ElementId> list3 = ((IEnumerable<ElementId>)list2).Distinct<ElementId>().ToList<ElementId>();
			if (list3.Count == 0)
			{
				return 0;
			}
			foreach (ElementId item3 in list3)
			{
				FilteredElementCollector val = new FilteredElementCollector(document, elementIds).OfCategoryId(item3);
				IList<Element> eleList = val.ToElements();
				DataTable table = Method.ElementParameter2Table(commandData, eleList);
				DataTable table2 = Method.ParameterIsRead(commandData, eleList, document);
				dataSet.Tables.Add(table);
				dataSet2.Tables.Add(table2);
			}
			ParameterEventHandler parameterEventHandler = new ParameterEventHandler();
			ElementOverrideEventHandler elementOverrideEventHandler = new ElementOverrideEventHandler();
			ResetElementOverrideEventHandler resetElementOverrideEventHandler = new ResetElementOverrideEventHandler();
			ExternalEvent g_exEvent = ExternalEvent.Create(parameterEventHandler);
			ExternalEvent g_exEvent2 = ExternalEvent.Create(elementOverrideEventHandler);
			ExternalEvent g_exEvent3 = ExternalEvent.Create(resetElementOverrideEventHandler);
			GlobalVar.G_handler = parameterEventHandler;
			GlobalVar.G_exEvent = g_exEvent;
			GlobalVar.G_handler1 = elementOverrideEventHandler;
			GlobalVar.G_exEvent1 = g_exEvent2;
			GlobalVar.G_handler3 = resetElementOverrideEventHandler;
			GlobalVar.G_exEvent3 = g_exEvent3;
			GlobalVar.MyDataSet = dataSet;
			GlobalVar.Is_Read_Only = dataSet2;
			HotGear_Parameter_Explorer hotGear_Parameter_Explorer = new HotGear_Parameter_Explorer();
			hotGear_Parameter_Explorer.InitializeComponent(commandData, document);
			hotGear_Parameter_Explorer.Show();
		}
		else
		{
			List<string> list4 = new List<string>();
			foreach (Document document2 in application2.get_Documents())
			{
				list4.Add(document2.get_Title());
			}
			GlobalVar.G_Doc_Selection = list4;
			CategorySelection categorySelection = new CategorySelection();
			categorySelection.InitializeComponent(commandData);
			categorySelection.ShowDialog();
			List<Element> g_Ele = GlobalVar.G_Ele;
			List<string> g_Cat_Selection = GlobalVar.G_Cat_Selection;
			Document g_Sel_Doc = GlobalVar.G_Sel_Doc;
			ICollection<ElementId> g_Eleid = GlobalVar.G_Eleid;
			if (g_Cat_Selection == null)
			{
				return 0;
			}
			DataSet dataSet3 = new DataSet();
			DataSet dataSet4 = new DataSet();
			List<ElementId> list5 = new List<ElementId>();
			foreach (Element item4 in g_Ele)
			{
				foreach (string item5 in g_Cat_Selection)
				{
					if (item4.get_Category().get_Name() == item5)
					{
						list5.Add(item4.get_Category().get_Id());
					}
				}
			}
			List<ElementId> list6 = ((IEnumerable<ElementId>)list5).Distinct<ElementId>().ToList<ElementId>();
			if (list6.Count == 0)
			{
				return 0;
			}
			foreach (ElementId item6 in list6)
			{
				FilteredElementCollector val3 = new FilteredElementCollector(g_Sel_Doc, g_Eleid).OfCategoryId(item6);
				IList<Element> eleList2 = val3.ToElements();
				DataTable table3 = Method.ElementParameter2Table(commandData, eleList2);
				DataTable table4 = Method.ParameterIsRead(commandData, eleList2, g_Sel_Doc);
				dataSet3.Tables.Add(table3);
				dataSet4.Tables.Add(table4);
			}
			ParameterEventHandler parameterEventHandler2 = new ParameterEventHandler();
			ElementOverrideEventHandler elementOverrideEventHandler2 = new ElementOverrideEventHandler();
			ResetElementOverrideEventHandler resetElementOverrideEventHandler2 = new ResetElementOverrideEventHandler();
			ExternalEvent g_exEvent4 = ExternalEvent.Create(parameterEventHandler2);
			ExternalEvent g_exEvent5 = ExternalEvent.Create(elementOverrideEventHandler2);
			ExternalEvent g_exEvent6 = ExternalEvent.Create(resetElementOverrideEventHandler2);
			GlobalVar.G_handler = parameterEventHandler2;
			GlobalVar.G_exEvent = g_exEvent4;
			GlobalVar.G_handler1 = elementOverrideEventHandler2;
			GlobalVar.G_exEvent1 = g_exEvent5;
			GlobalVar.G_handler3 = resetElementOverrideEventHandler2;
			GlobalVar.G_exEvent3 = g_exEvent6;
			GlobalVar.MyDataSet = dataSet3;
			GlobalVar.Is_Read_Only = dataSet4;
			HotGear_Parameter_Explorer hotGear_Parameter_Explorer2 = new HotGear_Parameter_Explorer();
			hotGear_Parameter_Explorer2.InitializeComponent(commandData, g_Sel_Doc);
			hotGear_Parameter_Explorer2.Show();
		}
		return 0;
	}
}
