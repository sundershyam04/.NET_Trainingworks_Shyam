using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Movie
   {
            public string Name { get; set; }

            public string Language { get; set; }

            public string Genre { get; set; }

            public int AvailableStock { get; set; }

             public int Cost { get; set; }

        public Movie(string n,string l,string g,int cost)
            {
                Name = n;
                Language = l;
                Genre = g;
                Cost = cost;
                AvailableStock = 10;
            }

        

        }
    }

