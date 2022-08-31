using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[10] {8,9,5,4,-1,2,55,774,1148,69};
             int i,n,max,min;
             int a=10;
            max = arr[0];
            min = arr[0];

            for(i = 1; i < a; i++)
            {
                if(arr[i] > max)  max = arr[i];

                if(arr[i] < min) min = arr[i];
            }
      Console.Write("Maximum element = {0}\n", max);
      Console.Write("Minimum element = {0}\n", min);
            Console.ReadLine();
        }
    }
}
