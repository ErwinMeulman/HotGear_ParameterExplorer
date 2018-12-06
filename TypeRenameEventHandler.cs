using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;

public class TypeRenameEventHandler
{
	public void Execute(UIApplication uiapp)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		Document document = uiapp.get_ActiveUIDocument().get_Document();
		UIDocument activeUIDocument = uiapp.get_ActiveUIDocument();
		Categories categories = document.get_Settings().get_Categories();
		List<Element> g_ElementList = GlobalVar.G_ElementList;
		List<string> g_ParameterName = GlobalVar.G_ParameterName;
		List<string> g_ParameterValue = GlobalVar.G_ParameterValue;
		for (int i = 0; i < g_ElementList.Count; i++)
		{
			if (g_ParameterName[i] == "Type Name")
			{
				IList<Element> list = new FilteredElementCollector(document).WhereElementIsElementType().ToElements();
				foreach (Element item in list)
				{
					if (item.get_Name() == g_ElementList[i].get_Name())
					{
						Transaction val = new Transaction(document);
						val.Start("SetName");
						item.set_Name(g_ParameterValue[i]);
						val.Commit();
					}
				}
			}
			else if (g_ParameterName[i] == "Family Name")
			{
				IList<Element> list2 = new FilteredElementCollector(document).OfClass(typeof(Family)).ToElements();
				foreach (Element item2 in list2)
				{
					if (item2.get_Name() == g_ElementList[i].get_Name())
					{
						Transaction val2 = new Transaction(document);
						val2.Start("SetName");
						item2.set_Name(g_ParameterValue[i]);
						val2.Commit();
					}
				}
			}
		}
	}

	public string GetName()
	{
		return "Family Rename";
	}
}
