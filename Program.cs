
namespace TranCongQuangPhu_LinQ_KTGK
{
    class Program
    {
        static List<Document> Listdocuments = new List<Document>();

        static void Main(string[] args)
        {
            //cau 1:
            Console.WriteLine("Cau 1");
            char c = 'y';
            while (c == 'y')
            {
                Console.WriteLine("Choose category (1. Book, 2.Newspaper, 3. Magazine)");
                int cate = int.Parse(Console.ReadLine());
                switch (cate)
                {
                    case 1:
                        Document document1 = new Book();
                        document1.Input();
                        document1.Display();
                        Listdocuments.Add(document1);
                        break;
                    case 2:
                        Document document2 = new Newspaper();
                        document2.Input();
                        document2.Display();
                        Listdocuments.Add(document2);

                        break;
                    case 3:
                        Document document3 = new Magazine();
                        document3.Input();
                        document3.Display();
                        Listdocuments.Add(document3);
                        break;
                }
                Console.Write("Press 'y' to continue...");
                c = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Cau 2");

            Console.WriteLine("Enter Category (1. Book, 2.Newspaper, 3. Magazine)");
            int cate2 = int.Parse(Console.ReadLine());
            var query2_339 = Listdocuments.Where(x => x.CateID == cate2).ToList();
            foreach (var item in query2_339)
            {
                item.Display();
            }

            //Cau3
            Console.WriteLine("Cau 3");

            var newspagerList = Listdocuments.OfType<Newspaper>().ToList();
            var query_339 = newspagerList.Where(x => (x.datePublished.Month == 3) && (x.datePublished.Year) == 2024).ToList();
            Console.WriteLine("Newspaper published in March 2024");
            foreach (var item in query_339)
            {
                Console.WriteLine(item.NameDoc);
            }

            Console.ReadKey();
        }
    }
}