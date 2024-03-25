using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranCongQuangPhu_LinQ_KTGK
{
    public class Book : Document
    {
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book()
        {
        }
        public Book(string Author, int PageCount) : base()
        {
            this.Author = Author;
            this.PageCount = PageCount;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Author: ");
            Author = Console.ReadLine();
            Console.Write("Enter PageCount: ");
            PageCount = int.Parse(Console.ReadLine());
            CateID = 1;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("PageCount: " + PageCount);
        }
    }
}
