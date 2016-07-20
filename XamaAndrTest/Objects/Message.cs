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
    public class Message
    {
        private User _sender;
        private User _receiver;
        private string _text;
        private DateTime _date;
        private string _status;

        public Message(User _sender, User _receiver, string _text, DateTime _date, string _status)
        {
            this._sender = _sender;
            this._receiver = _receiver;
            this._text = _text;
            this._date = _date;
            this._status = _status;
        }

        public User Sender
        {
            get
            {
                return _sender;
            }

            set
            {
                _sender = value;
            }
        }

        public User Receiver
        {
            get
            {
                return _receiver;
            }

            set
            {
                _receiver = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
    }
}