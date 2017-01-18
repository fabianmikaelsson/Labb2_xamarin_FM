using Android.App;
using Android.Widget;
using Android.OS;

namespace labb2_FM
{
	[Activity(Label = "labb2_FM", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}
	}
}

