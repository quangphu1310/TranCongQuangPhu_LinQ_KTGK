using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranCongQuangPhu_LinQ_KTGK
{
    public class Document
    {
        public int ID { get; set; }
        public string NameDoc { get; set; }
        public string NamePublisher { get; set; }
        public int CateID { get; set; }
        public Document()
        {

        }
        public Document(int ID, string NameDoc, string NamePublisher, int CateID)
        {
            this.ID = ID;
            this.NameDoc = NameDoc;
            this.NamePublisher = NamePublisher;
            this.CateID = CateID;
        }
        public virtual void Input()
        {
            Console.Write("Enter ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Enter NameDoc: ");
            NameDoc = Console.ReadLine();
            Console.Write("Enter NamePublisher: ");
            NamePublisher = Console.ReadLine();

        }
        public virtual void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("NameDoc: " + NameDoc);
            Console.WriteLine("NamePublisher: " + NamePublisher);

            Console.WriteLine("Cate: " + CateID);
        }
    }
}
