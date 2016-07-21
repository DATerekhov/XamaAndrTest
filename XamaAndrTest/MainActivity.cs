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
using XamaAndrTest.Objects;
using Android.Views.InputMethods;

namespace XamaAndrTest
{
    [Activity(Label = "MainActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        User user = new User();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button bLogin = FindViewById<Button>(Resource.Id.bLogin);
            Button bNextTest = FindViewById<Button>(Resource.Id.bNextActivityTemp);
            EditText etLogin = FindViewById<EditText>(Resource.Id.etLogin);
            EditText etPassword = FindViewById<EditText>(Resource.Id.etPassword);

            user.Login = "root";
            user.Password = "root";

            bLogin.Click += delegate
            {
                if ((user.Login == etLogin.Text.ToString()) && (user.Password == etPassword.Text.ToString()))
                {
                    Toast.MakeText(this, "Nice Login!", ToastLength.Short).Show();
                    Intent intern = new Intent(this, typeof(MenuActivity));
                    StartActivity(intern);
                }
                else
                {
                    Toast.MakeText(this, "Error Login!", ToastLength.Short).Show();
                }
            };

            bNextTest.Click += delegate {
                Intent intern = new Intent(this, typeof(MenuActivity));
                StartActivity(intern);
            };

        }
    }
}