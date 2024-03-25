using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranCongQuangPhu_LinQ_KTGK
{
    public class Newspaper : Document
    {
        public DateTime datePublished { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter datePublished: ");
            datePublished = DateTime.Parse(Console.ReadLine());
            CateID = 2;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("datePublished: " + datePublished);
        }
    }
}
