using System;

namespace ProjectCSharp
{
    class Doctor
    {
        public event EventHandler NewNumberCabinet;
        string surname;
        string timeOfReceipt;
        int numberOfCabinet;

        public Doctor(string surname, string timeofReceipt, int numberCabinet)
        {
            Surname = surname;
            TimeOfReceipt = timeofReceipt;
            NumberOfCabinet = numberCabinet;
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string TimeOfReceipt
        {
            get
            {
                return timeOfReceipt;
            }
            set
            {
                timeOfReceipt = value;
            }
        }

        public int NumberOfCabinet
        {
            get
            {
                return numberOfCabinet;
            }
            set
            {
                if (value > 0)
                {
                    numberOfCabinet = value;
                    NewNumberCabinet?.Invoke(this, new EventArgs());
                }
            }
        }

        public override string ToString()
        {
            return ($"Врач: {Surname} кабинет №{NumberOfCabinet}");
        }
    }
}

