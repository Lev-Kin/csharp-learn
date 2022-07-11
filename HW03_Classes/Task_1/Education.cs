using System;
 
namespace ProjectC_sharp
{
    class Education
    {
        private static string minister;
        private string type;
        private int year;
        private string institution;
 
        static Education()
        {
            minister = "Журавков";
        }
        public Education(string type, int year, string institution)
        {
               Minister_name = minister;
            Institution_type = type;
            Institution_year = year;
            Institution_name = institution;
        }
        public Education() : this("Университет", 1953, "БелГУТ") { }
        ~Education()
        {
            Console.WriteLine("\nОбъект класса уничтожен.");
        }
 
        public static string Minister_name
        {
            get { return minister; }
            set { minister = value; }
        }
        public string Institution_type
        {
            get { return type; }
            set { type = value; }
        }
        public int Institution_year
        {
            get { return year; }
            set
            {
                if (value < 1900)
                    throw new Exception("Год должен быть не меньше 1900! Программа завершена.");
                else
                    year = value;
            }
        }
        public string Institution_name
        {
            get { return institution; }
            set { institution = value; }
        }
        public override string ToString()
        {
            return "Министр образования: " + minister 
                + "\nУчреждение образования: " + type 
                + " " + institution + "\nГод постройки: " + year;
        }
    }
}

