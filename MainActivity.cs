using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Support.V7.App;
using Android.Text;
using Android.Views;
using Android.Widget;
using Com.Syncfusion.Charts;
using Java.Lang;
using Newtonsoft.Json;
using Plugin.Geolocator;
using Square.Picasso;
using Syncfusion.Android.ProgressBar;
using Syncfusion.SfPullToRefresh;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;
using AlertDialog = Android.Support.V7.App.AlertDialog;

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
