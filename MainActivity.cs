using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;

namespace Weather.Xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzc1OTk1QDMxMzgyZTM0MmUzMEpGUi96NGFrK2xrU0o2emJ1cHpmYm5mZkNqVEpQUEQ0MW1sbHNjUnJaZWs9");
            SetContentView(Resource.Layout.VistaPrincipal);


            EditText edittext = FindViewById<EditText>(Resource.Id.search_edit);

            FindViewById<EditText>(Resource.Id.search_edit).KeyPress += (object sender, View.KeyEventArgs e) =>
            {
                e.Handled = false;

                edittext.Text = edittext.Text;

                #region ELIMINAR
                if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                {
                    Toast.MakeText(this, edittext.Text, ToastLength.Short).Show();
                    e.Handled = true;
                }
                #endregion
            };


        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            return false;
        }

        //private void MainActivity_EditorAction(object sender, TextView.EditorActionEventArgs e)
        //{
        //    if (e.ActionId == Android.Views.InputMethods.ImeAction.Search)
        //    {
        //    }
        //    else
        //    {
        //        e.Handled = false;
        //    }
        //}



    }
}
