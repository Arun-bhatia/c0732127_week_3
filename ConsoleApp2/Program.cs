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
            Console.WriteLine("Enter village name");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter village name");
            String nm = Console.ReadLine();
            village newvill = new village(d, "Ghagon");
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

