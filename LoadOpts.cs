using Autodesk.Revit.DB;

internal class LoadOpts
{
	public bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
	{
		overwriteParameterValues = true;
		return true;
	}

	public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
	{
		source = 1;
		overwriteParameterValues = true;
		return true;
	}
}
