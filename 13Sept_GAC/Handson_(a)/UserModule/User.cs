using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class User
    {

        public enum Level

        {
            Silver = 2,
            Gold = 3,
            Platinum = 5

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
			if(borrowed_movies.Contains(m))
			{
				
				borrowed_movies.Remove(m);
                m.AvailableStock++;
                borrow_num--;

				double totalcost= days*m.Cost;

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

		public void Auth()
		{
			if(UserName =="Shyam" && Password=="shyam@9776")
			{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Succesfully");
                Console.ForegroundColor = ConsoleColor.White;

            }
			else
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login FAILED");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(1);
			}

		}

	}
}
