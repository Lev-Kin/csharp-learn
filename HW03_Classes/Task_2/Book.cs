using System;
 
namespace ProjectC_sharp
{
    class Book
    {
        private string title;
        private string author;
        static private string typography;
 
        static Book()
        {
            typography = "РОСМЭН";
        }
        public Book(string title = "Гарри Поттер",
                    string author = "Дж. К. Роулинг",
                    int edition = 10000,
                    double cost = 25.48)
        {
            Title = title;
            Author = author;
            Edition = edition;
            Cost = cost;
        }
        ~Book()
        {
            Console.WriteLine("\nУничтожена книга - " + Title);
        }
 
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public string Author
        {
            get { return author; }
            private set { author = value; }
        }
        public static string Typography
        {
            get { return typography; }
            set { typography = value; }
        }
 
        public int Edition { get; set; }
        public double Cost { get; set; }
 
        public double CostEdition()
        {
            return Edition * Cost;
        }
        public static int SameEdition(Book obj1, Book obj2)
        {
            return obj1.Edition + obj2.Edition;
        }
        public override string ToString()
        {
            return "Название: " + title +
                "\nАвтор: " + author +
                "\nИздательство: " + typography +
                "\nТираж: " + Edition + 
                "\nСтоимость: " + Cost +" руб" +
                "\nСтоимость тиража: " + CostEdition() + " руб\n";
        }
    }
}

