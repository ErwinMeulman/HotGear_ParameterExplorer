using Autodesk.Revit.UI;
using HotGearAllInOne;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HotGear
{
	public class HotGearPackage
	{
		private static string AddInPath = typeof(HotGearPackage).Assembly.Location;

		public HotGear_Parameter_Explorer m_MyForm;

		public Result OnStartup(UIControlledApplication application)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			this.m_MyForm = null;
			string text = "Hot Gear";
			try
			{
				application.CreateRibbonTab(text);
			}
			catch
			{
			}
			RibbonPanel val = application.CreateRibbonPanel(text, "Parameter Explorer");
			ContextualHelp contextualHelp = new ContextualHelp(2, "https://hotgearproject.wordpress.com/hot-gear-project-2/");
			PushButton val2 = val.AddItem(new PushButtonData("HotGear_IPE", "Instance", HotGearPackage.AddInPath, "InstanceParameterCollector")) as PushButton;
			val2.set_ToolTip("Collect Project Instance Elements Data");
			val2.set_LargeImage(HotGearPackage.RetriveImage("HotGearAllInOne.Resources.Instance.png"));
			val2.set_Image(HotGearPackage.RetriveImage("HotGearAllInOne.Resources.Instance_s.png"));
			val2.SetContextualHelp(contextualHelp);
			val.AddSeparator();
			PushButton val3 = val.AddItem(new PushButtonData("HotGear_TPE", "Type", HotGearPackage.AddInPath, "TypeParameterCollector")) as PushButton;
			val3.set_ToolTip("Collect Project Type Elements Data");
			val3.set_LargeImage(HotGearPackage.RetriveImage("HotGearAllInOne.Resources.Type.png"));
			val3.set_Image(HotGearPackage.RetriveImage("HotGearAllInOne.Resources.Type_s.png"));
			val3.SetContextualHelp(contextualHelp);
			return 0;
		}

		public Result OnShutdown(UIControlledApplication application)
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (this.m_MyForm != null && this.m_MyForm.Visible)
			{
				this.m_MyForm.Close();
			}
			return 0;
		}

		public static ImageSource RetriveImage(string imagePath)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(imagePath);
			switch (imagePath.Substring(imagePath.Length - 3))
			{
			case "jpg":
			{
				JpegBitmapDecoder jpegBitmapDecoder = new JpegBitmapDecoder(manifestResourceStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
				return jpegBitmapDecoder.Frames[0];
			}
			case "bmp":
			{
				BmpBitmapDecoder bmpBitmapDecoder = new BmpBitmapDecoder(manifestResourceStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
				return bmpBitmapDecoder.Frames[0];
			}
			case "png":
			{
				PngBitmapDecoder pngBitmapDecoder = new PngBitmapDecoder(manifestResourceStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
				return pngBitmapDecoder.Frames[0];
			}
			case "ico":
			{
				IconBitmapDecoder iconBitmapDecoder = new IconBitmapDecoder(manifestResourceStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
				return iconBitmapDecoder.Frames[0];
			}
			default:
				return null;
			}
		}
	}
}
