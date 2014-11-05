
using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace NuGetPackageExplorer.Core
{
	public class MainViewModel : ViewModel
	{
		public MainViewModel ()
		{
			Packages = new ObservableCollection<PackageViewModel> ();
			Packages.Add (new PackageViewModel { Id = "Json.NET",
				Version = "6.0.6" });
			Packages.Add (new PackageViewModel { Id = "Xamarin.Forms",
				Version = "1.2.3.4444",
				ImageUrl = "http://xamarin.com/content/images/nuget/xamarin.png" });
		}

		public ObservableCollection<PackageViewModel> Packages { get; private set; }
	}
}

