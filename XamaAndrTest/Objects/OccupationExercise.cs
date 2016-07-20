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
    public class OccupationExercise
    {
        private int _number;
        private CatalogExercise _catalogExercise;
        private String _mark;
        private Double _progress;
        private List<int> _exerciseParameters;

        public OccupationExercise(int _number, CatalogExercise _catalogExercise, string _mark, double _progress, List<int> _exerciseParameters)
        {
            this._number = _number;
            this._catalogExercise = _catalogExercise;
            this._mark = _mark;
            this._progress = _progress;
            this._exerciseParameters = _exerciseParameters;
        }

        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public CatalogExercise CatalogExercise
        {
            get
            {
                return _catalogExercise;
            }

            set
            {
                _catalogExercise = value;
            }
        }

        public string Mark
        {
            get
            {
                return _mark;
            }

            set
            {
                _mark = value;
            }
        }

        public double Progress
        {
            get
            {
                return _progress;
            }

            set
            {
                _progress = value;
            }
        }

        public List<int> ExerciseParameters
        {
            get
            {
                return _exerciseParameters;
            }

            set
            {
                _exerciseParameters = value;
            }
        }
    }
}