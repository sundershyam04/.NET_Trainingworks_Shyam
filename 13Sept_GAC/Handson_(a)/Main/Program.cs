using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Movie> MovList = new List<Movie>();

            Movie m1 = new Movie("RRR", "telugu","history",40);
            Movie m2 = new Movie("Sitaram", "telugu","romance",70);
            Movie m3 = new Movie("viruman", "tamil","action",90);
            Movie m4 = new Movie("enthiran", "tamil","Sci-fi",150);
            Movie m5 = new Movie("chakde", "hindi","documentary",95);
            Movie m6 = new Movie("lagaan", "hindi", "documentary",95);
            Movie m7 = new Movie("MsDHONI UNTOLD STORY", "hindi","biopic",100);
            Movie m8 = new Movie("Vikram", "tamil","thriller",120);
            Movie m9 = new Movie("83", "hindi","biopic",100);
            Movie m10 = new Movie("ak", "hindi", "action",90);

            MovList.Add(m1);
            MovList.Add(m2);
            MovList.Add(m3);
            MovList.Add(m4);
            MovList.Add(m5);
            MovList.Add(m6);
            MovList.Add(m7);
            MovList.Add(m8);
            MovList.Add(m9);
            MovList.Add(m10);


            //AddMovies(MovList);

           //Console.WriteLine("----movie list printing-----");
           //PrintList(MovList);

            // auth 

            User u1= new User(User.Level.Gold);

            Console.WriteLine("Enter Username");
            u1.UserName= Console.ReadLine();

            Console.WriteLine("Enter Password");

            u1.Password= Console.ReadLine();

            u1.Auth();  //authentication

            Console.WriteLine("----SEARCH MOVIES----- ");
            SearchMovies(MovList);


            u1.borrow(m1);
            u1.borrow(m1);
           
            u1.borrow(m1);  


            u1.m_return(m1,10);

            u1.borrow(m2);  //done

            u1.borrow(m3);   // err msg

            u1.m_return(m2,2);

            Console.WriteLine($"Count of borrowed movies {u1.borrowed_movies.Count}");
            


            //Console.WriteLine("---TOP SELLERS---");

            // MovList.Sort();

            Console.WriteLine("----movie list printing-----");
            PrintList(MovList);

        }

        private static void SearchMovies(List<Movie> MovList)
        {
            Console.WriteLine("Enter Movie Genre to search");
            string g = Console.ReadLine();

            Console.WriteLine("Enter language to search");
            string l = Console.ReadLine();

            bool status = false;
            foreach (var item in MovList)
            {


                if (item.Genre == g && item.Language == l)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Movies with {g} in {l} : {item.Name}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("---------------------");
                    status = true;
                }
                
            }
            if(status==false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("N0 movie of given filter search");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void PrintList(List<Movie> MovList)
        {
            foreach (var item in MovList)
            {

                Console.WriteLine(item.Name);
                Console.WriteLine(item.Language);
                Console.WriteLine(item.Genre);
                Console.WriteLine(item.AvailableStock);
                Console.WriteLine(item.Cost + "/ day");
                Console.WriteLine("-------------------------");

            }
        }

        //private static void AddMovies(List<Movie> MovList)
        //{
        //    Console.WriteLine("Enter no.of.movies to be added in list :");
        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        Movie m = new Movie();
        //        Console.WriteLine("Enter Movie name");
        //        m.Name = Console.ReadLine();
        //        Console.WriteLine("Enter language");
        //        m.Language = Console.ReadLine();
        //        Console.WriteLine("Enter Genre");
        //        m.Genre = Console.ReadLine();
        //        MovList.Add(m);

        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("=>Movie added successfully....");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}
    }
}
