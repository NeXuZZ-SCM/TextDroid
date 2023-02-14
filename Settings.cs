using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using Xamarin.Essentials;

namespace Weather.Xamarin
{
    [Activity(Label = "Settings", Theme = "@style/AppTheme", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class Settings : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

    }
}