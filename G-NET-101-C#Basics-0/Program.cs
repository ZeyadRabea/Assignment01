using System.Numerics;
using System.Reflection;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_101_C_Basics_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first 2 questions
            //    Book Book1 = new Book();
            //    // Book Book2 = new Book();

            //    Book1.Title = "The Great Gatsby";
            //    Book1.pages = 180;
            //    Book2.Title= "The Great Gatsby";
            //    Book2.pages= 180;
            //    Book2.Title= "To Kill a Mockingbird";
            //    Book2.pages= 281;
            //    Console.WriteLine(Book1);
            //    Console.WriteLine(Book1.ToString());
            //    Console.WriteLine(Book1.Equals(Book1));
            //    Console.WriteLine(Book1.GetHashCode());
            //    Console.WriteLine(Book1.GetType());
            //    //Console.WriteLine(Book2.GetHashCode());
            #endregion

            #region third question
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. 
            //int pages = "464";

            /*this is a compil-time error cuz you are trying to assign a string value to an integer variable.
             * how can i fix it?
             * just remove the double quotes around the number 464, so it becomes:
             * int pages = 464;
             */
            #endregion

            #region fourth question

            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);

            }

            catch
            {
                Console.WriteLine("you cannot divide by zero");
            }

            #endregion


        }
        #region first 2 questions
        //class Book
        //{
        //    public string Title { get; set; }
        //    public int pages;



        //    public override string ToString()
        //    {
        //        return Title + " has " + pages + " pages.";
        //    }
        //    //public override bool Equals(object? obj)
        //    //{
        //    //    Book Book1= (Book)obj;
        //    //    return this.Title == Book1.Title && this.pages == Book1.pages;
        //    //}
        //    public override int GetHashCode()
        //    {
        //        return HashCode.Combine(Title, pages);
        //    }

        //}
        #endregion
    }
}
