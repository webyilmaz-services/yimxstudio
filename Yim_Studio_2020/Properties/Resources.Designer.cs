using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Yim_Studio_2020.Properties
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	internal class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

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

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new System.Resources.ResourceManager("Yim_Studio_2020.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		internal static Bitmap YimLogo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("YimLogo", Resources.resourceCulture);
			}
		}

		internal static string YIMXCodeCompiler
		{
			get
			{
				return Resources.ResourceManager.GetString("YIMXCodeCompiler", Resources.resourceCulture);
			}
		}

		internal Resources()
		{
		}
	}
}