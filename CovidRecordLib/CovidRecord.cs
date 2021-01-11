using System;

namespace CovidRecordLib
{
    public class CovidRecord
    {
        private int _id;
        private string _city;
        private int _household;
        private int _tested;
        private int _sick;

        public CovidRecord()
        { }

        public CovidRecord(int id, string city, int household, int tested, int sick)
        {
            _id = id;
            _city = city;
            _household = household;
            _tested = tested;
            _sick = sick;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string City
        {
            get => _city;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                _city = value;
            }
        }

        public int Household
        {
            get => _household;
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException();
                _household = value;
            }
        }

        public int Tested
        {
            get => _tested;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _tested = value;

            }
        }

        public int Sick
        {
            get => _sick;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _sick = value;
            }
        }
    }
}
