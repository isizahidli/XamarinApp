using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinApp.Droid
{
    public class BackgroundService : Service
    {

        private const int NOTIF_ID = 1;
        private const string NOTIF_CHANNEL_ID = "Channel_Id";

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            StartForeground();

            return base.OnStartCommand(intent, flags, startId);
        }

        private void StartForeground()
        {
            Intent notificationIntent = new Intent(this, typeof(MainActivity));

        PendingIntent pendingIntent = PendingIntent.GetActivity(this, 0,
                notificationIntent, 0);

        StartForeground(NOTIF_ID, new NotificationCompat.Builder(this,
                NOTIF_CHANNEL_ID) // don't forget create a notification channel first
                .SetOngoing(true)
                .SetContentTitle("Xamarin")
                .SetContentText("Service is running background")
                .SetContentIntent(pendingIntent)
                .Build());         
    }
}
}