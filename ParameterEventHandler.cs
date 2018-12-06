using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ParameterEventHandler
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected I4, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Invalid comparison between Unknown and I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Invalid comparison between Unknown and I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Invalid comparison between Unknown and I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Invalid comparison between Unknown and I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected O, but got Unknown
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Invalid comparison between Unknown and I4
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Invalid comparison between Unknown and I4
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Invalid comparison between Unknown and I4
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Invalid comparison between Unknown and I4
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Invalid comparison between Unknown and I4
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected O, but got Unknown
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected O, but got Unknown
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e77: Expected O, but got Unknown
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected O, but got Unknown
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected O, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b7: Unknown result type (might be due to invalid IL or missing references)
		Document document = uiapp.get_ActiveUIDocument().get_Document();
		UIDocument activeUIDocument = uiapp.get_ActiveUIDocument();
		List<Element> g_ElementList = GlobalVar.G_ElementList;
		List<string> g_ParameterName = GlobalVar.G_ParameterName;
		List<string> g_ParameterValue = GlobalVar.G_ParameterValue;
		if (g_ElementList.Count == 0)
		{
			MessageBox.Show("Nothing Changed", "Notice");
		}
		else
		{
			string str = "";
			string str2 = "";
			str2 = str2 + "\r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------\r\nTime : " + DateTime.Now.ToString() + "\r\n---------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
			try
			{
				for (int i = 0; i < g_ElementList.Count; i++)
				{
					IList<Parameter> parameters = g_ElementList[i].GetParameters(g_ParameterName[i]);
					foreach (Parameter item in parameters)
					{
						Transaction val = new Transaction(document);
						val.Start("SetParameter");
						FailureHandlingOptions failureHandlingOptions = val.GetFailureHandlingOptions();
						MyFailuresPreProcessor myFailuresPreProcessor = new MyFailuresPreProcessor();
						failureHandlingOptions.SetFailuresPreprocessor(myFailuresPreProcessor);
						val.SetFailureHandlingOptions(failureHandlingOptions);
						try
						{
							str = "Error Log :\n";
							StorageType storageType = item.get_StorageType();
							StorageType storageType2;
							int num = default(int);
							switch ((int)storageType)
							{
							case 2:
							{
								DisplayUnit displayUnitSystem = document.get_DisplayUnitSystem();
								if ((int)displayUnitSystem == 0)
								{
									if ((int)item.get_DisplayUnitType() == 15)
									{
										object[] obj4 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj4[8] = ((object)storageType2).ToString();
										obj4[9] = "\r\nParameter Value : ";
										obj4[10] = g_ParameterValue[i].ToString();
										obj4[11] = "\r\n\r\n";
										str2 = string.Concat(obj4);
										str += str2;
										double num2 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 57.2957795 * -1.0;
										item.Set(num2);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 2)
									{
										object[] obj5 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj5[8] = ((object)storageType2).ToString();
										obj5[9] = "\r\nParameter Value : ";
										obj5[10] = g_ParameterValue[i].ToString();
										obj5[11] = "\r\n\r\n";
										str2 = string.Concat(obj5);
										str += str2;
										double num3 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 304.8 * -1.0;
										item.Set(num3);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 1)
									{
										object[] obj6 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj6[8] = ((object)storageType2).ToString();
										obj6[9] = "\r\nParameter Value : ";
										obj6[10] = g_ParameterValue[i].ToString();
										obj6[11] = "\r\n\r\n";
										str2 = string.Concat(obj6);
										str += str2;
										double num4 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 30.48 * -1.0;
										item.Set(num4);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 236)
									{
										object[] obj7 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj7[8] = ((object)storageType2).ToString();
										obj7[9] = "\r\nParameter Value : ";
										obj7[10] = g_ParameterValue[i].ToString();
										obj7[11] = "\r\n\r\n";
										str2 = string.Concat(obj7);
										str += str2;
										double num5 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 3.048 * -1.0;
										item.Set(num5);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 0 || (int)item.get_DisplayUnitType() == 9)
									{
										object[] obj8 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj8[8] = ((object)storageType2).ToString();
										obj8[9] = "\r\nParameter Value : ";
										obj8[10] = g_ParameterValue[i].ToString();
										obj8[11] = "\r\n\r\n";
										str2 = string.Concat(obj8);
										str += str2;
										double num6 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 0.3048 * -1.0;
										item.Set(num6);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 175)
									{
										object[] obj9 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj9[8] = ((object)storageType2).ToString();
										obj9[9] = "\r\nParameter Value : ";
										obj9[10] = g_ParameterValue[i].ToString();
										obj9[11] = "\r\n\r\n";
										str2 = string.Concat(obj9);
										str += str2;
										item.Set(Convert.ToDouble(g_ParameterValue[i]));
										val.Commit();
									}
									else
									{
										object[] obj10 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj10[8] = ((object)storageType2).ToString();
										obj10[9] = "\r\nParameter Value : ";
										obj10[10] = g_ParameterValue[i].ToString();
										obj10[11] = "\r\n\r\n";
										str2 = string.Concat(obj10);
										str += str2;
										item.Set(Convert.ToDouble(g_ParameterValue[i]));
										val.Commit();
									}
								}
								else if ((int)displayUnitSystem == 1)
								{
									if ((int)item.get_DisplayUnitType() == 15)
									{
										object[] obj11 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj11[8] = ((object)storageType2).ToString();
										obj11[9] = "\r\nParameter Value : ";
										obj11[10] = g_ParameterValue[i].ToString();
										obj11[11] = "\r\n\r\n";
										str2 = string.Concat(obj11);
										str += str2;
										double num7 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 57.2957795 * -1.0;
										item.Set(num7);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 5 || (int)item.get_DisplayUnitType() == 6)
									{
										object[] obj12 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj12[8] = ((object)storageType2).ToString();
										obj12[9] = "\r\nParameter Value : ";
										obj12[10] = g_ParameterValue[i].ToString();
										obj12[11] = "\r\n\r\n";
										str2 = string.Concat(obj12);
										str += str2;
										double num8 = Convert.ToDouble(g_ParameterValue[i]) * -1.0 / 12.0 * -1.0;
										item.Set(num8);
										val.Commit();
									}
									else if ((int)item.get_DisplayUnitType() == 175)
									{
										object[] obj13 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj13[8] = ((object)storageType2).ToString();
										obj13[9] = "\r\nParameter Value : ";
										obj13[10] = g_ParameterValue[i].ToString();
										obj13[11] = "\r\n\r\n";
										str2 = string.Concat(obj13);
										str += str2;
										item.Set(Convert.ToDouble(g_ParameterValue[i]));
										val.Commit();
									}
									else
									{
										object[] obj14 = new object[12]
										{
											str2,
											"Element Name : ",
											item.get_Element().get_Name(),
											"\r\nElement Id : ",
											(object)item.get_Element().get_Id(),
											"\r\nParameter Name : ",
											item.get_Definition().get_Name(),
											"\r\nParameter Storage Type : ",
											null,
											null,
											null,
											null
										};
										storageType2 = item.get_StorageType();
										obj14[8] = ((object)storageType2).ToString();
										obj14[9] = "\r\nParameter Value : ";
										obj14[10] = g_ParameterValue[i].ToString();
										obj14[11] = "\r\n\r\n";
										str2 = string.Concat(obj14);
										str += str2;
										item.Set(Convert.ToDouble(g_ParameterValue[i]));
										val.Commit();
									}
								}
								break;
							}
							case 4:
								if (int.TryParse(g_ParameterValue[i], out num))
								{
									object[] obj15 = new object[12]
									{
										str2,
										"Element Name : ",
										item.get_Element().get_Name(),
										"\r\nElement Id : ",
										(object)item.get_Element().get_Id(),
										"\r\nParameter Name : ",
										item.get_Definition().get_Name(),
										"\r\nParameter Storage Type : ",
										null,
										null,
										null,
										null
									};
									storageType2 = item.get_StorageType();
									obj15[8] = ((object)storageType2).ToString();
									obj15[9] = "\r\nParameter Value : ";
									obj15[10] = g_ParameterValue[i].ToString();
									obj15[11] = "\r\n\r\n";
									str2 = string.Concat(obj15);
									str += str2;
									int num9 = Convert.ToInt32(g_ParameterValue[i]);
									ElementId val2 = new ElementId(num9);
									item.Set(val2);
									val.Commit();
								}
								else
								{
									List<BuiltInCategory> list = new List<BuiltInCategory>();
									list.Add(-2000240);
									object[] obj16 = new object[12]
									{
										str2,
										"Element Name : ",
										item.get_Element().get_Name(),
										"\r\nElement Id : ",
										(object)item.get_Element().get_Id(),
										"\r\nParameter Name : ",
										item.get_Definition().get_Name(),
										"\r\nParameter Storage Type : ",
										null,
										null,
										null,
										null
									};
									storageType2 = item.get_StorageType();
									obj16[8] = ((object)storageType2).ToString();
									obj16[9] = "\r\nParameter Value : ";
									obj16[10] = g_ParameterValue[i].ToString();
									obj16[11] = "\r\n\r\n";
									str2 = string.Concat(obj16);
									str += str2;
									foreach (BuiltInCategory item2 in list)
									{
										FilteredElementCollector val3 = new FilteredElementCollector(document).OfCategory(item2);
										IList<Element> list2 = val3.ToElements();
										foreach (Element item3 in list2)
										{
											if (item3.get_Name() == g_ParameterValue[i])
											{
												item.Set(item3.get_Id());
											}
										}
									}
									val.Commit();
								}
								break;
							case 1:
							{
								object[] obj3 = new object[12]
								{
									str2,
									"Element Name : ",
									item.get_Element().get_Name(),
									"\r\nElement Id : ",
									(object)item.get_Element().get_Id(),
									"\r\nParameter Name : ",
									item.get_Definition().get_Name(),
									"\r\nParameter Storage Type : ",
									null,
									null,
									null,
									null
								};
								storageType2 = item.get_StorageType();
								obj3[8] = ((object)storageType2).ToString();
								obj3[9] = "\r\nParameter Value : ";
								obj3[10] = g_ParameterValue[i].ToString();
								obj3[11] = "\r\n\r\n";
								str2 = string.Concat(obj3);
								str += str2;
								if (int.TryParse(g_ParameterValue[i], out num))
								{
									item.Set(Convert.ToInt32(g_ParameterValue[i]));
									val.Commit();
								}
								else if (g_ParameterValue[i] == "Yes")
								{
									item.Set(Convert.ToInt32(1));
									val.Commit();
								}
								else if (g_ParameterValue[i] == "No")
								{
									item.Set(Convert.ToInt32(0));
									val.Commit();
								}
								break;
							}
							case 3:
							{
								object[] obj2 = new object[12]
								{
									str2,
									"Element Name : ",
									item.get_Element().get_Name(),
									"\r\nElement Id : ",
									(object)item.get_Element().get_Id(),
									"\r\nParameter Name : ",
									item.get_Definition().get_Name(),
									"\r\nParameter Storage Type : ",
									null,
									null,
									null,
									null
								};
								storageType2 = item.get_StorageType();
								obj2[8] = ((object)storageType2).ToString();
								obj2[9] = "\r\nParameter Value : ";
								obj2[10] = g_ParameterValue[i].ToString();
								obj2[11] = "\r\n\r\n";
								str2 = string.Concat(obj2);
								str += str2;
								item.Set(g_ParameterValue[i]);
								val.Commit();
								break;
							}
							case 0:
							{
								object[] obj = new object[12]
								{
									str2,
									"Element Name : ",
									item.get_Element().get_Name(),
									"\r\nElement Id : ",
									(object)item.get_Element().get_Id(),
									"\r\nParameter Name : ",
									item.get_Definition().get_Name(),
									"\r\nParameter Storage Type : ",
									null,
									null,
									null,
									null
								};
								storageType2 = item.get_StorageType();
								obj[8] = ((object)storageType2).ToString();
								obj[9] = "\r\nParameter Value : ";
								obj[10] = g_ParameterValue[i].ToString();
								obj[11] = "\r\n\r\n";
								str2 = string.Concat(obj);
								str += str2;
								item.Set(g_ParameterValue[i]);
								val.Commit();
								break;
							}
							default:
								val.Commit();
								break;
							}
						}
						catch (Exception ex)
						{
							TaskDialog.Show("Error Log", str + ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
							GlobalVar.Log += "Fail Input\r\n";
							val.Commit();
						}
					}
				}
			}
			catch (Exception ex2)
			{
				TaskDialog.Show("EventLog", ex2.ToString());
			}
			GlobalVar.Log += str2;
			GlobalVar.G_ElementList.Clear();
			GlobalVar.G_ParameterName.Clear();
			GlobalVar.G_ParameterValue.Clear();
		}
		GlobalVar.MethodThatPopulatesTheFrame();
	}

	public string GetName()
	{
		return "Set Parameter";
	}
}
