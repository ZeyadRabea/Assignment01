using System.Reflection;

namespace G_NET_101_C_Basics_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book();
            // Book Book2 = new Book();

            Book1.Title = "The Great Gatsby";
            Book1.pages = 180;
            //Book2.Title= "The Great Gatsby";
            //Book2.pages= 180;
            //Book2.Title= "To Kill a Mockingbird";
            //Book2.pages= 281;
            Console.WriteLine(Book1);
            Console.WriteLine(Book1.ToString());
            Console.WriteLine(Book1.Equals(Book1));
            Console.WriteLine(Book1.GetHashCode());
            Console.WriteLine(Book1.GetType());
            //Console.WriteLine(Book2.GetHashCode());

        }

        class Book
        {
            public string Title { get; set; }
            public int pages;



            public override string ToString()
            {
                return Title + " has " + pages + " pages.";
            }
            //public override bool Equals(object? obj)
            //{
            //    Book Book1= (Book)obj;
            //    return this.Title == Book1.Title && this.pages == Book1.pages;
            //}
            public override int GetHashCode()
            {
                return HashCode.Combine(Title, pages);
            }

        }
    }
}
