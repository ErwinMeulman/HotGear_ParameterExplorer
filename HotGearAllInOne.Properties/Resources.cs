using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace HotGearAllInOne.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = Resources.resourceMan = new ResourceManager("HotGearAllInOne.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static Bitmap gear
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("gear", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Icon gear1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("gear1", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		internal static Bitmap Instance
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Instance", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Instance_s
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Instance_s", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap page_copy
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("page_copy", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Type
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Type", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Type_s
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Type_s", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
