using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;
using System.IO;
using Android.Media;

namespace XamaAndrTest
{
    [Activity(Label = "PrepareActivity")]
    public class PrepareActivity : Activity, MediaPlayer.IOnPreparedListener, ISurfaceHolderCallback
    {
        private Button bnext;
        private VideoView videoView;
        private MediaPlayer mediaPlayer;
        private TableLayout tlPrepareParam;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Prepare);
            bnext = FindViewById<Button>(Resource.Id.bNext);
            videoView = FindViewById<VideoView>(Resource.Id.videoView1);
            tlPrepareParam = FindViewById<TableLayout>(Resource.Id.tlPrepareParam);

            /* 
            string pathLocal = "Assets/sport.mp4";
            videoView.SetVideoURI(Android.Net.Uri.Parse(pathLocal));
            videoView.SetMediaController(new MediaController(this));
            videoView.RequestFocus();
            videoView.Start();
            videoView.KeepScreenOn = true;
            */

            ISurfaceHolder holder = videoView.Holder;
            holder.SetType(SurfaceType.PushBuffers);
            holder.AddCallback(this);

            mediaPlayer = new MediaPlayer();
            Android.Content.Res.AssetFileDescriptor afd = Assets.OpenFd("sport.mp4");
            if (afd != null)
            {
                mediaPlayer.SetDataSource(afd.FileDescriptor, afd.StartOffset, afd.Length);
                mediaPlayer.Prepare();
                mediaPlayer.Start();
            }

            bnext.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ExerciseActivity));
                StartActivity(intent);
            };

            for (var i = 0; i < 2; i++)
            {
                var tvTemp = new TextView(this);
                tvTemp.SetText("Кол-во подходов", TextView.BufferType.Normal);

                var tvTemp2 = new TextView(this);
                tvTemp2.SetText("100..", TextView.BufferType.Normal);

                var trTemp = new TableRow(this);
                trTemp.AddView(tvTemp);
                trTemp.AddView(tvTemp2);

                tlPrepareParam.AddView(trTemp);
            }

        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            Toast.MakeText(this, "SurfaceCreated", ToastLength.Short).Show();
            mediaPlayer.SetDisplay(holder);
        }
        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            Console.WriteLine("SurfaceDestroyed");
        }
        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int w, int h)
        {
            Console.WriteLine("SurfaceChanged");
        }
        public void OnPrepared(MediaPlayer player)
        {
            
        }
    }
}