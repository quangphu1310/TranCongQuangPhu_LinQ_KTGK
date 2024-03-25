using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranCongQuangPhu_LinQ_KTGK
{
    public class Magazine : Document
    {
        public int NumberPublished { get; set; }
        public string PagePublished { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter NumberPublished: ");
            NumberPublished = int.Parse(Console.ReadLine());
            Console.Write("Enter PagePublished: ");
            PagePublished = Console.ReadLine();
            CateID = 3;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("NumberPublished: " + NumberPublished);
            Console.WriteLine("PagePublished: " + PagePublished);
        }
    }
}
