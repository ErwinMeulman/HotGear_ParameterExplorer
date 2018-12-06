using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using HotGearAllInOne;
using System.Collections.Generic;
using System.Data;
using System.Linq;

[Transaction()]
[Regeneration()]
public class TypeParameterCollector
{
	public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
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
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		GlobalVar.G_commandData = commandData;
		UIApplication application = commandData.get_Application();
		Document document = application.get_ActiveUIDocument().get_Document();
		UIDocument activeUIDocument = application.get_ActiveUIDocument();
		Application application2 = commandData.get_Application().get_Application();
		View activeView = document.get_ActiveView();
		GlobalVar.TypeORInstance = "Family Type";
		Selection selection = application.get_ActiveUIDocument().get_Selection();
		ICollection<ElementId> elementIds = selection.GetElementIds();
		ICollection<ElementId> collection = new List<ElementId>();
		List<Element> list = new List<Element>();
		foreach (ElementId item in elementIds)
		{
			try
			{
				Element element = document.GetElement(item);
				ElementId typeId = element.GetTypeId();
				Element element2 = document.GetElement(typeId);
				collection.Add(typeId);
				list.Add(element2);
			}
			catch
			{
			}
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
				}
			}
			List<ElementId> list3 = ((IEnumerable<ElementId>)list2).Distinct<ElementId>().ToList<ElementId>();
			foreach (ElementId item3 in list3)
			{
				FilteredElementCollector val = new FilteredElementCollector(document, collection).OfCategoryId(item3);
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
			DataSet dataSet3 = new DataSet();
			DataSet dataSet4 = new DataSet();
			List<ElementId> list6 = ((IEnumerable<ElementId>)list5).Distinct<ElementId>().ToList<ElementId>();
			foreach (ElementId item6 in list6)
			{
				FilteredElementCollector val3 = new FilteredElementCollector(g_Sel_Doc, g_Eleid).OfCategoryId(item6);
				IList<Element> list7 = new List<Element>();
				foreach (Element item7 in val3)
				{
					list7.Add(item7);
				}
				DataTable table3 = Method.ElementParameter2Table(commandData, list7);
				DataTable table4 = Method.ParameterIsRead(commandData, list7, g_Sel_Doc);
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
