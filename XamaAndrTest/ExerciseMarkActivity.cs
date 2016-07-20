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
    [Activity(Label = "ExerciseMarkActivity")]
    public class ExerciseMarkActivity : Activity
    {
        private List<string> listItem;
        private ListView lvMark;
        private TableLayout tlMarkParams;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ExerciseMark);

            listItem = new List<string>();
            listItem.Add("Легко");
            listItem.Add("Средне");
            listItem.Add("Тяжело");
            listItem.Add("Не сделал");

            lvMark = FindViewById<ListView>(Resource.Id.lvMark);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItemChecked, listItem);
            lvMark.Adapter = adapter;
            lvMark.ChoiceMode = ChoiceMode.Single;

            lvMark.ItemClick += delegate
            {
                Toast.MakeText(this, lvMark.CheckedItemPosition.ToString(), ToastLength.Short).Show();
            };

            tlMarkParams = FindViewById<TableLayout>(Resource.Id.tlMarkParams);
            var trTemp = new TableRow(this);
            var tvTemp = new TextView(this);
            var etTemp = new EditText(this);
            var tempParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent, 1);

            trTemp.AddView(tvTemp, tempParams);
            trTemp.AddView(etTemp, tempParams);
        }
    }
}