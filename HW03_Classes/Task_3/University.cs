using System;
 
namespace ProjectC_sharp
{
    class University
    {
        private string rector;
        private int quantity;
        private int year;
        private string univer;
 
        public University(string univer, int year, string rector, int quantity)
        {
            Rector = rector;
            Quantity = quantity;
            Year = year;
            Univer = univer;
        }
        public University() : this("ГГТУ им. П.О.Сухого", 1968, "Тимошин", 7700) { }
 
        public string Rector
        {
            get { return rector; }
            set { rector = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Year
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
        public string Univer
        {
            get { return univer; }
            set { univer = value; }
        }
 
        public override string ToString()
        {
            return "Учреждение образования: " + Univer +
                "\nГод постройки: " + Year +
                "\nРектор: " + Rector +
                "\nКоличество учащихся: " + Quantity;
        }
        public static int Compare(University obj1, University obj2)
        {
            if (obj1.quantity < obj2.quantity)
                return -100;
            else
                if (obj1.quantity > obj2.quantity)
                return 100;
            else
                return 0;
        }
    }
}

