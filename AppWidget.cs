using Android.App;
using Android.Appwidget;
using Android.Content;
using Android.Widget;
using System.Timers;

namespace Weather.Xamarin
{
    [BroadcastReceiver(Label = "Weather.Xamarin Weather")]
    [IntentFilter(new string[] { "android.appwidget.action.APPWIDGET_UPDATE" })]
    [MetaData("android.appwidget.provider", Resource = "@xml/appwidgetprovider")]
    public class AppWidget : AppWidgetProvider
    {
        private static Timer timer;

        public override void OnUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds)
        {
            // Inicializar el temporizador para que llame a OnUpdate cada 2 segundos
            timer = new Timer(60000);
            timer.Elapsed += (sender, e) => OnUpdate(context, appWidgetManager, appWidgetIds);
            timer.AutoReset = true;
            timer.Enabled = true;

            UpdateWidget(context, appWidgetManager, appWidgetIds);

        }

        private static void UpdateWidget(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds)
        {
            // To prevent any ANR timeouts, we perform the update in a service
            context.StartService(new Intent(context, typeof(UpdateService)));
        }
    }
}