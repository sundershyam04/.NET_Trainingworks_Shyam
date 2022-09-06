using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesspecifierDemo
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string City { get; set; }
        //property with the name "this", it will make the class behave like a array
        private string[] stateNames = new string[5] { "MH", "KA", "KE", "PB", "UP" };

        //indexer
        public string this[int h]
        {
            get { return stateNames[h]; }
            set { stateNames[h] = value; }
        }



    }
}
