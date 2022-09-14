using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using UserModule;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.InteropServices;


//14 sept - Serialization

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Movie> MovList = new List<Movie>();

            Movie m1 = new Movie("RRR", "telugu", "history", 40);
            Movie m2 = new Movie("Sitaram", "telugu", "romance", 70);
            Movie m3 = new Movie("viruman", "tamil", "action", 90);
            Movie m4 = new Movie("enthiran", "tamil", "Sci-fi", 150);
            Movie m5 = new Movie("chakde", "hindi", "documentary", 95);
            Movie m6 = new Movie("lagaan", "hindi", "documentary", 95);
            Movie m7 = new Movie("MsDHONI UNTOLD STORY", "hindi", "biopic", 100);
            Movie m8 = new Movie("Vikram", "tamil", "thriller", 120);
            Movie m9 = new Movie("83", "hindi", "biopic", 100);
            Movie m10 = new Movie("ak", "hindi", "action", 90);

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

            User u1 = new User(User.Level.Gold);

            u1.Currdate = DateTime.Now.ToShortDateString();

            Console.WriteLine("Enter Username");
            u1.UserName = Console.ReadLine();

            Console.WriteLine("Enter Password");

            u1.Password = Console.ReadLine();

            u1.ValidateUser();  //authentication


            //binaryserialization for u1

            //  BinarySerialization(u1);

            //deserialize
            //  BinaryDeSerialization();


            if (u1.LoginStatus == false)
                Environment.Exit(1);

            Console.WriteLine("--------------------------------------");

            //for xml to be serialzized we must have class to have parameterless ctor

            Console.WriteLine("----SEARCH MOVIES----- ");
            SearchMovies(MovList, u1);

            XmlSerialization(u1); // searched movie as array of movie in xml file

            Console.WriteLine("-----Movie seen------");

            //seen movies

            JsonSerialization(m7, m9, m10, u1);

            Console.WriteLine("========================");




            /////-------------------soap serialization---------

            u1.borrow(m1);

            FileStream fs_soap = new FileStream(@"stockvalue.soap", FileMode.Create, FileAccess.Write);

            SoapFormatter sf = new SoapFormatter();

            sf.Serialize(fs_soap, m1);

            fs_soap.Close();

            Console.WriteLine("=========================================");

            u1.borrow(m1);

            u1.borrow(m1);

            Console.WriteLine("----------Binaryserialcost------------");

            u1.m_return(m1, 10);

            //1
            Console.WriteLine($"Count of borrowed movies {u1.borrowed_movies.Count}");
            BinarySerialcost(u1);

            u1.borrow(m2);  //done

            u1.borrow(m3);   // err msg

            //2

            u1.m_return(m2, 2);

            Console.WriteLine($"Count of borrowed movies {u1.borrowed_movies.Count}");
            BinarySerialcost(u1);

            //Console.WriteLine("---TOP SELLERS---");

            // MovList.Sort();

            Console.WriteLine("----movie list printing-----");
            PrintList(MovList);
            Console.ReadLine();
        }

        private static void BinarySerialcost(User u1)
        {
            BinaryFormatter bf1 = new BinaryFormatter();

            FileStream fsb = new FileStream(@"Cost.bin", FileMode.Create, FileAccess.Write);

            bf1.Serialize(fsb, u1.Tempcost);

            fsb.Close();

            FileStream fsr = new FileStream(@"Cost.bin", FileMode.Open, FileAccess.Read);
            double v = (double)bf1.Deserialize(fsr);

            Console.WriteLine($"Temp cost(deserialize) :Rs{v}");
            fsr.Close();
        }

        private static void JsonSerialization(Movie m7, Movie m9, Movie m10, User u1)
        {
            u1.Movieseen.Add(m7);

            u1.Movieseen.Add(m9);

            u1.Movieseen.Add(m10);

            string s;
            s = JsonConvert.SerializeObject(u1.Movieseen);

            Console.WriteLine(s);

            FileStream fs_json = new FileStream(@"movieseen.json", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs_json);

            sw.Write(s);

            sw.Close(); fs_json.Close();
        }

        private static void XmlSerialization(User u1)
        {
            FileStream fs_xml = new FileStream(@"Searchedmovies.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(List<Movie>));

            xs.Serialize(fs_xml, u1.SearchedMovies);

            fs_xml.Flush(); fs_xml.Close(); fs_xml.Dispose();
        }

        private static void BinaryDeSerialization()
        {
            Console.WriteLine("--------------------------------------");

            FileStream fs1 = new FileStream(@"Loginstatus.bin", FileMode.Open, FileAccess.Read);

            BinaryFormatter formatter1 = new BinaryFormatter();

            User u1_deser = (User)formatter1.Deserialize(fs1);

            Console.WriteLine($"Username : {u1_deser.UserName}");

            Console.WriteLine($"Login status : {u1_deser.LoginStatus}");

            Console.WriteLine($"UserLevel : {u1_deser.UserLevel}");

            Console.WriteLine($"Date : {u1_deser.Currdate}");



            Console.WriteLine("-->DeSerialized Successfully");
            
        }

        private static void BinarySerialization(User u1)
        {
            Console.WriteLine("*************************************");

            FileStream fs = new FileStream(@"Loginstatus.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, u1);

            fs.Flush(); fs.Close(); fs.Dispose();

            Console.WriteLine("-->Serialized Successfully");

            Console.WriteLine("*************************************");
        }

        private static void SearchMovies(List<Movie> MovList,User u)
        {
            List<Movie> searchmov = new List<Movie>();
            Console.WriteLine("Enter Movie Genre to search");
            string g = Console.ReadLine();

            Console.WriteLine("Enter language to search");
            string l = Console.ReadLine();

            bool status = false;
            foreach (var item in MovList)
            {


                if (item.Genre == g && item.Language == l)
                {
                    searchmov.Add(item);
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

            u.SearchedMovies=searchmov;

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
