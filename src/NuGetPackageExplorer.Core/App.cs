
using Xamarin.Forms;

namespace NuGetPackageExplorer.Core
{
	public class App
	{
		public static Page GetMainPage ()
		{
			var mainPage = new MainPage ();
			mainPage.BindingContext = new MainViewModel ();
			return mainPage;
		}
	}
}
