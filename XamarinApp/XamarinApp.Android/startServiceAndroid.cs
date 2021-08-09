using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinApp.Droid.startServiceAndroid))]
namespace XamarinApp.Droid
{
    public class startServiceAndroid : IStartService
    {
        public void StartForegroundServiceCompat()
        {
            var intent = new Intent(MainActivity.Instance, typeof(myLocationService));


            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                MainActivity.Instance.StartForegroundService(intent);
            }
            else
            {
                MainActivity.Instance.StartService(intent);
            }

        }
    }

    [Service]
    public class myLocationService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            Thread.Sleep(10000);
            int i = 0;
            while (i<5)
            {
                Thread.Sleep(1000);

                AddLog($"Bu test logudur({i++}). Services");

            }

            return StartCommandResult.Sticky;

        }

        public async void AddLog(string log)
        {
            await Task.Run(() =>
            {
                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://10.21.143.236:1010/" + "api/Home/AddLog");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = $"\"{log}\"";
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                }
                catch
                {

                }
            });
        }
    }
}
