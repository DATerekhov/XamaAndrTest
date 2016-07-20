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
    public class ExerciseParameter
    {
        private string _name;
        private string _parameterType;

        public ExerciseParameter(string _name, string _parameterType)
        {
            this._name = _name;
            this._parameterType = _parameterType;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string ParameterType
        {
            get
            {
                return _parameterType;
            }

            set
            {
                _parameterType = value;
            }
        }
    }
}