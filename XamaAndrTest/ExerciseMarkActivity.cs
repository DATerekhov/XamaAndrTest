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
        private Button bGoToMenuActivity;

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

            tlMarkParams = FindViewById<TableLayout>(Resource.Id.tlMarkParams);

            lvMark.ItemClick += delegate
            {
                if (lvMark.CheckedItemPosition == 3 && tlMarkParams.ChildCount == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        var tvTemp = new TextView(this);
                        tvTemp.SetText("Параметр", TextView.BufferType.Normal);

                        var etTemp = new EditText(this);
                        etTemp.InputType = Android.Text.InputTypes.ClassNumber;
                        
                        var trTemp = new TableRow(this);

                        trTemp.AddView(tvTemp);
                        trTemp.AddView(etTemp);

                        tlMarkParams.AddView(trTemp);
                    }
                }
                else if (lvMark.CheckedItemPosition != 3 && tlMarkParams.ChildCount != 0)
                {
                    tlMarkParams.RemoveAllViews();
                }
            };

            bGoToMenuActivity = FindViewById<Button>(Resource.Id.bGoToMenuActivity);

            bGoToMenuActivity.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MenuActivity));
                StartActivity(intent);
            };
        }
    }
}