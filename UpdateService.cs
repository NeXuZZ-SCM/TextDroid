using Android.App;
using Android.Appwidget;
using Android.Content;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.IO;
using Xamarin.Essentials;

namespace Weather.Xamarin
{
    [Service]
    public class UpdateService : Service
    {
        [System.Obsolete]
        public override void OnStart(Intent intent, int startId)
		{
			// Build the widget update for today
			RemoteViews updateViews = BuildUpdate(this);

			// Push update for this widget to the home screen
			ComponentName thisWidget = new ComponentName(this, Java.Lang.Class.FromType(typeof(AppWidget)).Name);
			AppWidgetManager manager = AppWidgetManager.GetInstance(this);
			manager.UpdateAppWidget(thisWidget, updateViews);
		}

		public override IBinder OnBind(Intent intent)
		{
			// We don't need to bind to this service
			return null;
		}

		public RemoteViews BuildUpdate(Context context)
		{
			RemoteViews updateViews = new RemoteViews(context.PackageName, Resource.Layout.widget);



            var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var filename = Path.Combine(path.ToString(), "download/text.txt");
            string content;

            using (StreamReader sr = new StreamReader(filename))
            {
                content = sr.ReadToEnd();
            }

            //updateViews.SetTextViewText(Resource.Id.widgettemperatur, GetString(Resource.String.TotalVisa));
            updateViews.SetTextViewText(Resource.Id.widgettemperatur, content);
            return updateViews;
		}

    }
}