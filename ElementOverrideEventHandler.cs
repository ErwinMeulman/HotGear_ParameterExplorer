using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

public class ElementOverrideEventHandler
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
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		Document document = uiapp.get_ActiveUIDocument().get_Document();
		UIDocument activeUIDocument = uiapp.get_ActiveUIDocument();
		Transaction val = new Transaction(document);
		val.Start("ElementOverride");
		document.Regenerate();
		val.Commit();
	}

	public string GetName()
	{
		return "Element Override";
	}
}
