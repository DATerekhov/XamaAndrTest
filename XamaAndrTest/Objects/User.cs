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

namespace XamaAndrTest.Objects
{
    public class User
    {
        private string _login;
        private string _password;
        private string _role;
        private string _fio;
        private object _foto;
        private string _contacts;

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
            }
        }

        public string Fio
        {
            get
            {
                return _fio;
            }

            set
            {
                _fio = value;
            }
        }

        public object Foto
        {
            get
            {
                return _foto;
            }

            set
            {
                _foto = value;
            }
        }

        public string Contacts
        {
            get
            {
                return _contacts;
            }

            set
            {
                _contacts = value;
            }
        }

        public User(string login, string password, string role, string fio, object foto, string contacts)
        {
            _login = login;
            _password = password;
            _role = role;
            _fio = fio;
            _foto = foto;
            _contacts = contacts;
        }
        public User() { }
    }
}