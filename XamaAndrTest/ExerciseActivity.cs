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

namespace XamaAndrTest
{
    [Activity(Label = "ExerciseActivity")]
    public class ExerciseActivity : Activity
    {
        //private TextView tvExerciseName;
        // private ScrollView svParameters;
        private TableLayout tlParameters;
        private VideoView vvExerciseVideo;
        //private Button bStartExercise;
        //private ProgressBar pbExerciseProgress;

        private Button bSkip;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Exercise);

            tlParameters = FindViewById<TableLayout>(Resource.Id.tlParameters);
            vvExerciseVideo = FindViewById<VideoView>(Resource.Id.vvExerciseVideo);
            vvExerciseVideo.SetVideoURI(Android.Net.Uri.Parse("https://www.youtube.com/watch?v=np0HVaZKDv0"));
            vvExerciseVideo.SetMediaController(new MediaController(this));
            vvExerciseVideo.RequestFocus();

            bSkip = FindViewById<Button>(Resource.Id.bSkip);
            bSkip.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ExerciseMarkActivity));
                StartActivity(intent);
            };
        }
    }
}