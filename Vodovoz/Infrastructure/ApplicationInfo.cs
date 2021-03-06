﻿using System;
using QS.Project.VersionControl;
using QSSupportLib;

namespace Vodovoz.Infrastructure
{
	public class ApplicationInfo: IApplicationInfo
	{
		private AppVersion appVersion = new AppVersion();

		public string ProductName => appVersion.Product;

		public string Edition => appVersion.Edition;

		public Version Version => appVersion.Version;

		public string SerialNumber => String.Empty;
	}
}
