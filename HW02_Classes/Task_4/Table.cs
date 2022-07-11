using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
//    Win  UniCODE
// ╣  185  \u2563
// ║  186  \u2551
// ╗  187  \u2557
// ╝  188  \u255d
// ╚  200  \u255a
// ╔  201  \u2554
// ╩  202  \u2569
// ╦  203  \u2566
// ╠  204  \u2560
// ═  205  \u2550
// ╬  206  \u256c
 
namespace ConsoleApp1
{
    class Table
    {
        private string title;
        private string colum_head1;
        private string colum_head2;
        private int row_width1;
        private int row_width2;
 
        public Table(string title, string colum_head1, int row_width1, string colum_head2, int row_width2)
        {
            this.title = title;
            this.colum_head1 = colum_head1;
            this.colum_head2 = colum_head2;
            this.row_width1 = row_width1;
            this.row_width2 = row_width2;
        }
 
        public void Up()
        {
            Console.WriteLine(title);
 
            Console.Write('\u2554');
            Console.Write("".PadLeft(row_width1, '\u2550'));
            Console.Write('\u2566');
            Console.Write("".PadLeft(row_width2, '\u2550'));
            Console.WriteLine('\u2557');
 
            Console.Write('\u2551');
            Console.Write(colum_head1.PadLeft(row_width1));
            Console.Write('\u2551');
            Console.Write(colum_head2.PadLeft(row_width2));
            Console.WriteLine('\u2551');
 
            Console.Write('\u2560');
            Console.Write("".PadLeft(row_width1, '\u2550'));
            Console.Write('\u256c');
            Console.Write("".PadLeft(row_width2, '\u2550'));
            Console.WriteLine('\u2563');
        }
 
        public void Middle(double x, double fx)
        {
            Console.Write('\u2551');
            Console.Write(Math.Round(x, 4).ToString().PadLeft(row_width1));
            Console.Write('\u2551');
            Console.Write(Math.Round(fx, 4).ToString().PadLeft(row_width2));
            Console.WriteLine('\u2551');
        }
 
        public void Down()
        {
            Console.Write('\u255a');
            Console.Write("".PadLeft(row_width1, '\u2550'));
            Console.Write('\u2569');
            Console.Write("".PadLeft(row_width2, '\u2550'));
            Console.WriteLine('\u255d');
        }
    }
}

