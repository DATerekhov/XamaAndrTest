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
    public class Client : User
    {
        private int _growth;
        private List<Weight> _weights;
        private List<Trainer> _trainers;
        private String _presenseStatus;

        public Client(string login, string password, string role, string fio, object foto, string contacts, int growth, Weight weight, string presenseStatus) : base(login, password, role, fio, foto, contacts)
        {
            _growth = growth;
            _weights = new List<Weight>();
            _weights.Add(weight);
            _trainers = new List<Trainer>();
            _presenseStatus = presenseStatus;
        }

        public int Growth
        {
            get
            {
                return _growth;
            }

            set
            {
                _growth = value;
            }
        }

        public List<Weight> Weights
        {
            get
            {
                return _weights;
            }

            set
            {
                _weights = value;
            }
        }

        public List<Trainer> Trainers
        {
            get
            {
                return _trainers;
            }
        }

        public string PresenseStatus
        {
            get
            {
                return _presenseStatus;
            }

            set
            {
                _presenseStatus = value;
            }
        }

        public Trainer GetCurrentTrainer()
        {
            return _trainers[_trainers.Count - 1];
        }

        public void SetTrainer(Trainer trainer)
        {
            _trainers.Add(trainer);
        }

        public void SetWeight(Weight weight)
        {
            _weights.Add(weight);
        }
    }
}