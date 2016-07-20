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
    public class Trainer : User
    {
        private String _information;
        private List<Client> _clients;

        public string Information
        {
            get
            {
                return _information;
            }

            set
            {
                _information = value;
            }
        }

        public List<Client> Clients
        {
            get
            {
                return _clients;
            }
        }

        public Trainer(string login, string password, string role, string fio, object foto, string contacts, string _information) : base(login, password, role, fio, foto, contacts)
        {
            this._information = _information;
            _clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            _clients.Add(client);
        }
    }
}