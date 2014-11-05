
using System;

namespace NuGetPackageExplorer.Core
{
	public class PackageViewModel
	{
		public PackageViewModel ()
		{
			ImageUrl = "packageicon.png";
		}

		public string Id { get; set; }
		public string Version { get; set; }
		public string ImageUrl { get; set; }
	}
}

