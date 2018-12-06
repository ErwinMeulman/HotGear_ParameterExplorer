using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using HotGearAllInOne;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class Method
{
	private const double _inch_to_mm = 25.4;

	private const double _foot_to_mm = 304.79999999999995;

	public static string GetMACAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text = string.Empty;
		NetworkInterface[] array = allNetworkInterfaces;
		foreach (NetworkInterface networkInterface in array)
		{
			if (text == string.Empty)
			{
				IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
				text = networkInterface.GetPhysicalAddress().ToString();
			}
		}
		return text;
	}

	public static string CalculateMD5Hash(string input, int no)
	{
		int i = 0;
		StringBuilder stringBuilder = new StringBuilder();
		for (; i < no; i++)
		{
			MD5 mD = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(input);
			byte[] array = mD.ComputeHash(bytes);
			for (int j = 0; j < array.Length; j++)
			{
				stringBuilder.Append(array[j].ToString("x2"));
			}
			input = stringBuilder.ToString();
		}
		return input;
	}

	public static string CalculateSHA1Hash(string input)
	{
		using (SHA1Managed sHA1Managed = new SHA1Managed())
		{
			byte[] array = sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				byte b = array2[i];
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}
	}

	public static bool DomainNetwork(Document doc)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		string a = Method.CalculateMD5Hash(IPGlobalProperties.GetIPGlobalProperties().DomainName, 3);
		if (!(a == "d1f90dffcf31cd3422a7150eb1383c3e9ba1352387ac086b0b649ff5016c2f67578ee0f079a35bb5854f94344462b6bf"))
		{
			MessageBox.Show("This app is only authorized on specific domain network.");
			return false;
		}
		string a2 = GlobalVar.G_revitversion = doc.get_Application().get_VersionNumber();
		GlobalVar.G_license = "License : Domain Network";
		if (a2 == "2016")
		{
			return true;
		}
		MessageBox.Show("This License is only for 2016 Revit Version.");
		return false;
	}

	public static bool TrialVersionCheck(Document doc)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		string text = GlobalVar.G_revitversion = doc.get_Application().get_VersionNumber();
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).ToString() + "\\Autodesk\\Structural\\Common Data\\" + text + "\\Data\\Other\\";
		string path = text2 + Method.CalculateMD5Hash("HG_ParameterExplorer_Days", 1) + ".cfg";
		string path2 = text2 + Method.CalculateMD5Hash("HG_ParameterExplorer_Key", 1) + ".cfg";
		Directory.CreateDirectory(text2);
		DateTime dateTime = DateTime.Now;
		string input = dateTime.AddDays(30.0).ToLongDateString();
		string contents = Method.CalculateMD5Hash(input, 6);
		bool flag = false;
		string mACAddress = Method.GetMACAddress();
		string input2 = Method.CalculateSHA1Hash(Method.CalculateMD5Hash(mACAddress, 9));
		string empty = string.Empty;
		if (text == "2015")
		{
			empty = Method.CalculateMD5Hash(input2, 15);
			goto IL_0127;
		}
		if (text == "2016")
		{
			empty = Method.CalculateMD5Hash(input2, 16);
			goto IL_0127;
		}
		if (text == "2017")
		{
			empty = Method.CalculateMD5Hash(input2, 17);
			goto IL_0127;
		}
		MessageBox.Show("This Addin current is only support 2015-2017 Revit Version.");
		return false;
		IL_0127:
		string a = Method.CalculateSHA1Hash(empty);
		try
		{
			if (a == File.ReadAllText(path2))
			{
				GlobalVar.G_license = "License : Active";
				flag = true;
			}
		}
		catch
		{
			try
			{
				for (int i = 0; i < 34; i++)
				{
					dateTime = DateTime.Now;
					dateTime = dateTime.AddDays((double)i);
					if (Method.CalculateMD5Hash(dateTime.ToLongDateString(), 6) == File.ReadAllText(path))
					{
						GlobalVar.G_license = "License : Trial";
						GlobalVar.G_TrialDay = i;
						WF_About wF_About = new WF_About();
						flag = true;
						break;
					}
					if (i > 32)
					{
						GlobalVar.G_license = "License : Not Available";
						GlobalVar.G_TrialDay = 0;
						WF_About wF_About2 = new WF_About();
						wF_About2.Show();
						flag = false;
					}
				}
			}
			catch
			{
				GlobalVar.G_license = "License : Trial";
				GlobalVar.G_TrialDay = 30;
				File.WriteAllText(path, contents);
				File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.Archive);
				flag = true;
			}
		}
		if (!flag)
		{
			return false;
		}
		return true;
	}

	public static DataTable ElementParameter2Table(ExternalCommandData cmddata, IList<Element> EleList)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Invalid comparison between Unknown and I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Invalid comparison between Unknown and I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Invalid comparison between Unknown and I4
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Invalid comparison between Unknown and I4
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Invalid comparison between Unknown and I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Invalid comparison between Unknown and I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Invalid comparison between Unknown and I4
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Invalid comparison between Unknown and I4
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Invalid comparison between Unknown and I4
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Invalid comparison between Unknown and I4
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Invalid comparison between Unknown and I4
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Invalid comparison between Unknown and I4
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Invalid comparison between Unknown and I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected I4, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected I4, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected O, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		UIApplication application = cmddata.get_Application();
		Document document = application.get_ActiveUIDocument().get_Document();
		DataTable dataTable = new DataTable();
		List<string> list = new List<string>();
		list.Clear();
		Dictionary<BuiltInParameter, string> dictionary = new Dictionary<BuiltInParameter, string>();
		foreach (Element Ele in EleList)
		{
			IList<Parameter> orderedParameters = Ele.GetOrderedParameters();
			foreach (Parameter item in orderedParameters)
			{
				list.Add(item.get_Definition().get_Name());
			}
		}
		List<string> list2 = (from q in list.Distinct()
		orderby q
		select q).ToList();
		dataTable.Columns.Add("ElementId");
		dataTable.Columns.Add("ElementGUID");
		dataTable.Columns.Add("Category");
		foreach (Element Ele2 in EleList)
		{
			try
			{
				string name = Ele2.get_Name();
				if (!(name == ""))
				{
					try
					{
						dataTable.Columns.Add("ElementName");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				ElementType val = document.GetElement(Ele2.GetTypeId()) as ElementType;
				string familyName = val.get_FamilyName();
				if (!(familyName == ""))
				{
					try
					{
						dataTable.Columns.Add("Family Name");
					}
					catch
					{
					}
				}
			}
			catch
			{
				try
				{
					string familyName2 = (Ele2 as ElementType).get_FamilyName();
					if (!(familyName2 == ""))
					{
						try
						{
							dataTable.Columns.Add("Family Name");
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				string name2 = document.GetElement(Ele2.GetTypeId()).get_Name();
				try
				{
					dataTable.Columns.Add("Type Name");
				}
				catch
				{
				}
			}
			catch
			{
			}
			try
			{
				ElementId ownerViewId = Ele2.get_OwnerViewId();
				if (!(((object)ownerViewId).ToString() == "-1"))
				{
					try
					{
						dataTable.Columns.Add("OwnerView");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		foreach (string item2 in list2)
		{
			dataTable.Columns.Add(item2);
		}
		List<string> list3 = new List<string>();
		list3.Clear();
		foreach (Element Ele3 in EleList)
		{
			list3.Add(((object)Ele3.get_Id()).ToString());
			list3.Add(Ele3.get_UniqueId().ToString());
			list3.Add(Ele3.get_Category().get_Name().ToString());
			try
			{
				string name3 = Ele3.get_Name();
				if (!(name3 == ""))
				{
					try
					{
						list3.Add(name3);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				ElementType val2 = document.GetElement(Ele3.GetTypeId()) as ElementType;
				string familyName3 = val2.get_FamilyName();
				if (!(familyName3 == ""))
				{
					try
					{
						list3.Add(familyName3);
					}
					catch
					{
					}
				}
			}
			catch
			{
				try
				{
					string familyName4 = (Ele3 as ElementType).get_FamilyName();
					if (!(familyName4 == ""))
					{
						try
						{
							list3.Add(familyName4);
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				string name4 = document.GetElement(Ele3.GetTypeId()).get_Name();
				list3.Add(name4);
			}
			catch
			{
			}
			try
			{
				ElementId ownerViewId2 = Ele3.get_OwnerViewId();
				if (!(((object)ownerViewId2).ToString() == "-1"))
				{
					Element element = document.GetElement(ownerViewId2);
					list3.Add(element.get_Name());
				}
			}
			catch
			{
			}
			double num;
			foreach (string item3 in list2)
			{
				try
				{
					Parameter val3 = Ele3.LookupParameter(item3);
					if (item3 == Ele3.get_Parameter(-1004005).get_Definition().get_Name())
					{
						if ((int)val3.get_DisplayUnitType() == 2)
						{
							List<string> list4 = list3;
							num = val3.AsDouble() * 304.8;
							list4.Add(num.ToString("#0.000"));
						}
						else if ((int)val3.get_DisplayUnitType() == 1)
						{
							List<string> list5 = list3;
							num = val3.AsDouble() * 30.48;
							list5.Add(num.ToString("#0.000 cm"));
						}
						else if ((int)val3.get_DisplayUnitType() == 0)
						{
							List<string> list6 = list3;
							num = val3.AsDouble() * 0.3048;
							list6.Add(num.ToString("#0.000 m"));
						}
						else
						{
							list3.Add(val3.AsValueString());
						}
					}
					else if (item3 == Ele3.get_Parameter(-1012805).get_Definition().get_Name())
					{
						if ((int)val3.get_DisplayUnitType() == 12)
						{
							List<string> list7 = list3;
							num = val3.AsDouble() * 0.09290304;
							list7.Add(num.ToString("#0.000 m²"));
						}
						else if ((int)val3.get_DisplayUnitType() == 20)
						{
							List<string> list8 = list3;
							num = val3.AsDouble() * 144.0;
							list8.Add(num.ToString("#0.000 in²"));
						}
						else if ((int)val3.get_DisplayUnitType() == 11)
						{
							List<string> list9 = list3;
							num = val3.AsDouble();
							list9.Add(num.ToString("#0.000 SF"));
						}
						else
						{
							list3.Add(val3.AsValueString());
						}
					}
					else if (item3 == Ele3.get_Parameter(-1012806).get_Definition().get_Name())
					{
						if ((int)val3.get_DisplayUnitType() == 14)
						{
							List<string> list10 = list3;
							num = val3.AsDouble() * 0.02831685;
							list10.Add(num.ToString("#0.000 m³"));
						}
						else if ((int)val3.get_DisplayUnitType() == 24)
						{
							List<string> list11 = list3;
							num = val3.AsDouble() * 28316.85;
							list11.Add(num.ToString("#0 cm³"));
						}
						else if ((int)val3.get_DisplayUnitType() == 25)
						{
							List<string> list12 = list3;
							num = val3.AsDouble() * 28316850.0;
							list12.Add(num.ToString("#0 mm³"));
						}
						else if ((int)val3.get_DisplayUnitType() == 23)
						{
							List<string> list13 = list3;
							num = val3.AsDouble() * 1728.0;
							list13.Add(num.ToString("#0.000 in³"));
						}
						else if ((int)val3.get_DisplayUnitType() == 13)
						{
							List<string> list14 = list3;
							num = val3.AsDouble();
							list14.Add(num.ToString("#0.000 CF"));
						}
						else if ((int)val3.get_DisplayUnitType() == 10)
						{
							List<string> list15 = list3;
							num = val3.AsDouble() * 0.03703704;
							list15.Add(num.ToString("#0.000 CY"));
						}
						else if ((int)val3.get_DisplayUnitType() == 26)
						{
							List<string> list16 = list3;
							num = val3.AsDouble() * 28.31685;
							list16.Add(num.ToString("#0.000 L"));
						}
						else
						{
							list3.Add(val3.AsValueString());
						}
					}
					else
					{
						StorageType storageType = val3.get_StorageType();
						switch ((int)storageType)
						{
						case 2:
							list3.Add(val3.AsValueString().ToString());
							break;
						case 4:
							list3.Add(val3.AsValueString() + "[" + (object)val3.AsElementId() + "]");
							break;
						case 1:
							list3.Add(val3.AsValueString() + "[" + val3.AsInteger() + "]");
							break;
						case 3:
							list3.Add(val3.AsString());
							break;
						case 0:
							list3.Add(val3.AsString());
							break;
						}
					}
				}
				catch
				{
					try
					{
						Parameter val4 = Ele3.LookupParameter(item3);
						StorageType storageType2 = val4.get_StorageType();
						switch ((int)storageType2)
						{
						case 2:
							list3.Add(val4.AsValueString().ToString());
							break;
						case 4:
							list3.Add(val4.AsValueString() + "[" + (object)val4.AsElementId() + "]");
							break;
						case 1:
							list3.Add(val4.AsValueString() + "[" + val4.AsInteger() + "]");
							break;
						case 3:
							list3.Add(val4.AsString());
							break;
						case 0:
							list3.Add(val4.AsString());
							break;
						}
					}
					catch
					{
						list3.Add(string.Empty);
					}
				}
			}
			try
			{
				Location location = Ele3.get_Location();
				if (((object)Ele3.get_Location()).ToString() == "Autodesk.Revit.DB.LocationCurve")
				{
					try
					{
						dataTable.Columns.Add("Start X");
						dataTable.Columns.Add("Start Y");
						dataTable.Columns.Add("Start Z");
						dataTable.Columns.Add("End X");
						dataTable.Columns.Add("End Y");
						dataTable.Columns.Add("End Z");
					}
					catch
					{
					}
					LocationCurve val5 = location as LocationCurve;
					XYZ endPoint = val5.get_Curve().GetEndPoint(0);
					XYZ endPoint2 = val5.get_Curve().GetEndPoint(1);
					List<string> list17 = list3;
					num = endPoint.get_X() * 304.79999999999995;
					list17.Add(num.ToString("#0.000"));
					List<string> list18 = list3;
					num = endPoint.get_Y() * 304.79999999999995;
					list18.Add(num.ToString("#0.000"));
					List<string> list19 = list3;
					num = endPoint.get_Z() * 304.79999999999995;
					list19.Add(num.ToString("#0.000"));
					List<string> list20 = list3;
					num = endPoint2.get_X() * 304.79999999999995;
					list20.Add(num.ToString("#0.000"));
					List<string> list21 = list3;
					num = endPoint2.get_Y() * 304.79999999999995;
					list21.Add(num.ToString("#0.000"));
					List<string> list22 = list3;
					num = endPoint2.get_Z() * 304.79999999999995;
					list22.Add(num.ToString("#0.000"));
				}
				else if (((object)Ele3.get_Location()).ToString() == "Autodesk.Revit.DB.LocationPoint")
				{
					try
					{
						dataTable.Columns.Add("Location X");
						dataTable.Columns.Add("Location Y");
						dataTable.Columns.Add("Location Z");
					}
					catch
					{
					}
					LocationPoint val6 = location as LocationPoint;
					XYZ point = val6.get_Point();
					List<string> list23 = list3;
					num = point.get_X() * 304.79999999999995;
					list23.Add(num.ToString("#0.000"));
					List<string> list24 = list3;
					num = point.get_Y() * 304.79999999999995;
					list24.Add(num.ToString("#0.000"));
					List<string> list25 = list3;
					num = point.get_Z() * 304.79999999999995;
					list25.Add(num.ToString("#0.000"));
				}
			}
			catch
			{
			}
			dataTable.Rows.Add(list3.ToArray());
			list3.Clear();
		}
		return dataTable;
	}

	public static DataTable ParameterIsRead(ExternalCommandData cmddata, IList<Element> EleList, Document S_Doc)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected I4, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		UIApplication application = cmddata.get_Application();
		Document document = application.get_ActiveUIDocument().get_Document();
		DataTable dataTable = new DataTable();
		DataColumn[] array = new DataColumn[1];
		List<string> list = new List<string>();
		list.Clear();
		foreach (Element Ele in EleList)
		{
			IList<Parameter> orderedParameters = Ele.GetOrderedParameters();
			foreach (Parameter item in orderedParameters)
			{
				list.Add(item.get_Definition().get_Name());
			}
		}
		List<string> list2 = (from q in list.Distinct()
		orderby q
		select q).ToList();
		dataTable.Columns.Add("ElementId");
		array[0] = dataTable.Columns["ElementId"];
		dataTable.Columns.Add("ElementGUID");
		dataTable.Columns.Add("Category");
		foreach (Element Ele2 in EleList)
		{
			try
			{
				string name = Ele2.get_Name();
				if (!(name == ""))
				{
					try
					{
						dataTable.Columns.Add("ElementName");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				ElementType val = document.GetElement(Ele2.GetTypeId()) as ElementType;
				string name2 = val.get_Name();
				if (!(name2 == ""))
				{
					try
					{
						dataTable.Columns.Add("Family Name");
					}
					catch
					{
					}
				}
			}
			catch
			{
				try
				{
					string name3 = (Ele2 as ElementType).get_Name();
					if (!(name3 == ""))
					{
						try
						{
							dataTable.Columns.Add("Family Name");
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				string name4 = document.GetElement(Ele2.GetTypeId()).get_Name();
				try
				{
					dataTable.Columns.Add("Type Name");
				}
				catch
				{
				}
			}
			catch
			{
			}
			try
			{
				ElementId ownerViewId = Ele2.get_OwnerViewId();
				if (!(((object)ownerViewId).ToString() == "-1"))
				{
					try
					{
						dataTable.Columns.Add("OwnerView");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		foreach (string item2 in list2)
		{
			dataTable.Columns.Add(item2);
		}
		List<string> list3 = new List<string>();
		foreach (Element Ele3 in EleList)
		{
			list3.Add(((object)Ele3.get_Id()).ToString());
			list3.Add(Ele3.get_UniqueId().ToString());
			list3.Add(Ele3.get_Category().get_Name().ToString());
			try
			{
				string name5 = Ele3.get_Name();
				if (!(name5 == ""))
				{
					try
					{
						list3.Add("True");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				ElementType val2 = document.GetElement(Ele3.GetTypeId()) as ElementType;
				string name6 = val2.get_Name();
				if (!(name6 == ""))
				{
					try
					{
						list3.Add("True");
					}
					catch
					{
					}
				}
			}
			catch
			{
				try
				{
					string name7 = (Ele3 as ElementType).get_Name();
					if (!(name7 == ""))
					{
						try
						{
							list3.Add("True");
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			try
			{
				string name8 = document.GetElement(Ele3.GetTypeId()).get_Name();
				list3.Add("True");
			}
			catch
			{
			}
			try
			{
				ElementId ownerViewId2 = Ele3.get_OwnerViewId();
				if (!(((object)ownerViewId2).ToString() == "-1"))
				{
					Element element = document.GetElement(ownerViewId2);
					list3.Add("True");
				}
			}
			catch
			{
			}
			foreach (string item3 in list2)
			{
				if (!S_Doc.get_IsLinked())
				{
					try
					{
						Parameter val3 = Ele3.LookupParameter(item3);
						StorageType storageType = val3.get_StorageType();
						bool isReadOnly;
						switch ((int)storageType)
						{
						case 2:
							isReadOnly = val3.get_IsReadOnly();
							list3.Add(isReadOnly.ToString() + ",Double");
							break;
						case 4:
							isReadOnly = val3.get_IsReadOnly();
							list3.Add(isReadOnly.ToString() + ",ElementId");
							break;
						case 1:
							isReadOnly = val3.get_IsReadOnly();
							list3.Add(isReadOnly.ToString() + ",Integer");
							break;
						case 3:
							isReadOnly = val3.get_IsReadOnly();
							list3.Add(isReadOnly.ToString());
							break;
						case 0:
							isReadOnly = val3.get_IsReadOnly();
							list3.Add(isReadOnly.ToString());
							break;
						}
					}
					catch
					{
						list3.Add(string.Empty);
					}
				}
				else
				{
					list3.Add("True");
				}
			}
			try
			{
				Location location = Ele3.get_Location();
				if (((object)Ele3.get_Location()).ToString() == "Autodesk.Revit.DB.LocationCurve")
				{
					try
					{
						dataTable.Columns.Add("Start X");
						dataTable.Columns.Add("Start Y");
						dataTable.Columns.Add("Start Z");
						dataTable.Columns.Add("End X");
						dataTable.Columns.Add("End Y");
						dataTable.Columns.Add("End Z");
					}
					catch
					{
					}
					LocationCurve val4 = location as LocationCurve;
					XYZ endPoint = val4.get_Curve().GetEndPoint(0);
					XYZ endPoint2 = val4.get_Curve().GetEndPoint(1);
					list3.Add("True");
					list3.Add("True");
					list3.Add("True");
					list3.Add("True");
					list3.Add("True");
					list3.Add("True");
				}
				else if (((object)Ele3.get_Location()).ToString() == "Autodesk.Revit.DB.LocationPoint")
				{
					try
					{
						dataTable.Columns.Add("Location X");
						dataTable.Columns.Add("Location Y");
						dataTable.Columns.Add("Location Z");
					}
					catch
					{
					}
					list3.Add("True");
					list3.Add("True");
					list3.Add("True");
					LocationPoint val5 = location as LocationPoint;
					XYZ point = val5.get_Point();
				}
			}
			catch
			{
			}
			dataTable.Rows.Add(list3.ToArray());
			list3.Clear();
		}
		dataTable.PrimaryKey = array;
		return dataTable;
	}

	public static DataTable TypeRename(ExternalCommandData cmddata, IList<Element> EleList)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		UIApplication application = cmddata.get_Application();
		Document document = application.get_ActiveUIDocument().get_Document();
		return new DataTable();
	}

	public static string RealString(double a)
	{
		return a.ToString("0.##");
	}

	public static string PointStringMm(XYZ p)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		return string.Format("{0},{1},{2}", Method.RealString(p.get_X() * 304.79999999999995), Method.RealString(p.get_Y() * 304.79999999999995), Method.RealString(p.get_Z() * 304.79999999999995));
	}

	public static List<Type> GetStorageType(IList<Element> elementlist, List<string> parameterName)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		List<Type> list = new List<Type>();
		foreach (Element item in elementlist)
		{
			foreach (string item2 in parameterName)
			{
				foreach (Parameter parameter in item.GetParameters(item2))
				{
					StorageType storageType = parameter.get_StorageType();
					switch ((int)storageType)
					{
					case 2:
						list.Add(typeof(double));
						break;
					case 4:
						list.Add(typeof(int));
						break;
					case 1:
						list.Add(typeof(int));
						break;
					case 3:
						list.Add(typeof(string));
						break;
					case 0:
						list.Add(typeof(string));
						break;
					}
				}
			}
		}
		return list;
	}
}
