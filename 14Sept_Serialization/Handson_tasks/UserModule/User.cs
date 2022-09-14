using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UserModule
{

	[Serializable]
    public class User
    {

        public enum Level

        {
            Silver = 2,
            Gold = 3,
            Platinum = 5

        }
		private List<Movie> _movieseen=new List<Movie>();

		public List<Movie> Movieseen
		{
			get { return _movieseen; }
			set { _movieseen = value; }
		}

		private double _tempcost;

		public double Tempcost
		{
			get { return _tempcost; }
			set { _tempcost = value; }
		}


		public List<Movie> borrowed_movies;
        public User(Level lvl)
		{

			UserLevel = (int)lvl;
	        borrowed_movies= new List<Movie>();	
        }

		public int borrow_num = 0;
		public void borrow(Movie m)
		{
			if(m.AvailableStock >0)
			{
				if(this.borrow_num < UserLevel)
				{
                    borrowed_movies.Add(m);
					borrow_num++;
                    m.AvailableStock--;
					Console.WriteLine("=>Borrowed successfully");

                }
				else
				{
					Console.WriteLine($"{(Level)UserLevel} limit reached");
				}

            }
			else
			{
                Console.WriteLine("Movie is out of stock");
            }
				

        }

		public void m_return(Movie m,int days)
		{
			if (borrowed_movies.Contains(m))
			{

				borrowed_movies.Remove(m);
				m.AvailableStock++;
				borrow_num--;

				double totalcost = days * m.Cost;
				Tempcost = totalcost;

				Console.WriteLine($"Cost to be paid :Rs{totalcost}");
				Console.WriteLine("-->Returned successfully");
			
			}

			
		}
		



		public int UserLevel { get; set; }


		private string _username;

		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}



		private string _password;

		public string Password

		{
			get { return _password; }
			set { _password = value; }
		}

		public bool LoginStatus { get; private set; }

		private string _date;
		public string Currdate
		{
			get { return _date; }
			 set { _date = value; }
		}

		private List<Movie> _searchmov= new List<Movie>();

		public List<Movie> SearchedMovies
		{
			get { return _searchmov; }
			set { _searchmov = value; }
		}


		public void ValidateUser()//9998886661 9998886661shyam@97
        {
			if(UserName =="123" && Password== "1234")
			{
				LoginStatus = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Succesfully");
                Console.ForegroundColor = ConsoleColor.White;

            }
			else
			{
				LoginStatus=false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login FAILED");
                Console.ForegroundColor = ConsoleColor.White;
               
			}

		}

	}
}
