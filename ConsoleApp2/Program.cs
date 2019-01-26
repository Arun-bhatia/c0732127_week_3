using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            village newvill = new village(45, "Ghagon");
            newvill.showvillageloc();
        }
    }
    public class village
    {
        int distance = 0;
        String village_name = "";
        public village(int dist, String villName)
            {
            distance = dist;
            village_name = villName;
            }
        public void showvillageloc()
        {
            Console.WriteLine(village_name+" is "+distance+" km away");
        }
    }
}

