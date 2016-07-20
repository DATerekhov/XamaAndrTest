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
    public class Occupation
    {
        private Client _client;
        private Trainer _trainer;
        private DateTime _date;
        private TimeSpan _occupationStart;
        private TimeSpan _occupationEnd;
        private String _status;
        private String _purpose;
        private List<OccupationExercise> _exercises;
        private String _mark;
        private Double _calorificValue;
        private Double _estimatedExecutionPlan;

        public Occupation(Client _client, Trainer _trainer, DateTime _date, TimeSpan _occupationStart, TimeSpan _occupationEnd, string _status, string _purpose, List<OccupationExercise> _exercises, string _mark, double _calorificValue, double _estimatedExecutionPlan)
        {
            this._client = _client;
            this._trainer = _trainer;
            this._date = _date;
            this._occupationStart = _occupationStart;
            this._occupationEnd = _occupationEnd;
            this._status = _status;
            this._purpose = _purpose;
            this._exercises = _exercises;
            this._mark = _mark;
            this._calorificValue = _calorificValue;
            this._estimatedExecutionPlan = _estimatedExecutionPlan;
        }

        public Client Client
        {
            get
            {
                return _client;
            }

            set
            {
                _client = value;
            }
        }

        public Trainer Trainer
        {
            get
            {
                return _trainer;
            }

            set
            {
                _trainer = value;
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

        public TimeSpan OccupationStart
        {
            get
            {
                return _occupationStart;
            }

            set
            {
                _occupationStart = value;
            }
        }

        public TimeSpan OccupationEnd
        {
            get
            {
                return _occupationEnd;
            }

            set
            {
                _occupationEnd = value;
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

        public string Purpose
        {
            get
            {
                return _purpose;
            }

            set
            {
                _purpose = value;
            }
        }

        public List<OccupationExercise> Exercises
        {
            get
            {
                return _exercises;
            }

            set
            {
                _exercises = value;
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

        public double EstimatedExecutionPlan
        {
            get
            {
                return _estimatedExecutionPlan;
            }

            set
            {
                _estimatedExecutionPlan = value;
            }
        }

        public void AddExercise(OccupationExercise exercise)
        {
            _exercises.Add(exercise);
        }
    }
}