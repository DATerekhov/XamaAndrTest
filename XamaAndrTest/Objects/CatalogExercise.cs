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
    public class CatalogExercise
    {
        private String _name;
        private String _type;
        private String _equipment;
        private Object _video;
        private String _description;
        private Double _calorificValue;
        private List<ExerciseParameter> _parameters;

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

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Equipment
        {
            get
            {
                return _equipment;
            }

            set
            {
                _equipment = value;
            }
        }

        public object Video
        {
            get
            {
                return _video;
            }

            set
            {
                _video = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public double CalorificValue
        {
            get
            {
                return _calorificValue;
            }

            set
            {
                _calorificValue = value;
            }
        }

        public List<ExerciseParameter> Parameters
        {
            get
            {
                return _parameters;
            }

            set
            {
                _parameters = value;
            }
        }

        public CatalogExercise(string _name, string _type, string _equipment, object _video, string _description, double _calorificValue, List<ExerciseParameter> _parameters)
        {
            this._name = _name;
            this._type = _type;
            this._equipment = _equipment;
            this._video = _video;
            this._description = _description;
            this._calorificValue = _calorificValue;
            this._parameters = _parameters;
        }

        public CatalogExercise()
        {

        }
    }
}