using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Yim_Studio_2020.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string _l
		{
			get
			{
				return (string)this["_l"];
			}
			set
			{
				this["_l"] = value;
			}
		}

		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}

		public Settings()
		{
		}
	}
}