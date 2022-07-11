using System;

namespace ProjectCSharp
{
    class Patient
    {
        string surname { get; set; }
        string diagnosis { get; set; }
        string date { get; set; }
        string time { get; set; }
        int cabinetNumber;

        public Patient(string name, string diagnosis, string date, string time, int numberCabinet)
        {
            Surname = name;
            Diagnosis = diagnosis;
            Date = date;
            Time = time;
            CabinetNumber = numberCabinet;
        }

        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
            }
        }

        public string Diagnosis
        {
            get => diagnosis;
            set
            {
                diagnosis = value;
            }
        }

        public string Date
        {
            get => date;
            set
            {
                date = value;
            }
        }

        public string Time
        {
            get => time;
            set
            {
                time = value;
            }
        }

        public void ChangeCabinetNumber(object doc, EventArgs args)
        {
            if (doc != null)
                cabinetNumber = ((Doctor)doc).NumberOfCabinet;
        }

        public int CabinetNumber
        {
            get => cabinetNumber;
            set
            {
                if (value > 0)
                    cabinetNumber = value;
            }
        }

        public override string ToString()
        {
            return ($"╠═════════╬═════════════╬═════════════╣\n" +
                    $"║{Surname,9}║{Date,13}║{Diagnosis,13}║");
        }
    }
}

