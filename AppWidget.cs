using Android.App;
using Android.Appwidget;
using Android.Content;
using System.Timers;

namespace Weather.Xamarin
{
    [BroadcastReceiver(Label = "TextDroid.Xamarin CardText")]
    [IntentFilter(new string[] { "android.appwidget.action.APPWIDGET_UPDATE" })]
    [MetaData("android.appwidget.provider", Resource = "@xml/appwidgetprovider")]
    public class AppWidget : AppWidgetProvider
    {
        private static Timer timer;

        public override void OnUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds)
        {
            // To prevent any ANR timeouts, we perform the update in a service
            context.StartService(new Intent(context, typeof(UpdateService)));
        }
    }
}