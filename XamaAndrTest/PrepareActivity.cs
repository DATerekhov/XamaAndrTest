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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Prepare);
            bnext = FindViewById<Button>(Resource.Id.bNext);
            videoView = FindViewById<VideoView>(Resource.Id.videoView1);
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
            /*
            var descriptor = Assets.OpenFd("sport.mp4");
            mediaPlayer.SetDataSource(descriptor.FileDescriptor, descriptor.StartOffset, descriptor.Length);
            mediaPlayer.Prepare();
            mediaPlayer.Looping = true;
            mediaPlayer.SetScreenOnWhilePlaying(true);
            mediaPlayer.Start();
            */
            bnext.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ExerciseActivity));
                StartActivity(intent);
            };

        }

        public void Surface(ISurfaceHolder holder)
        {

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