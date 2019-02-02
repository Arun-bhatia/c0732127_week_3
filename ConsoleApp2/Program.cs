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
            Console.WriteLine("Enter village dist");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter village name");
            String nm = Console.ReadLine();
            villages newvill = new villages(d, nm);
            newvill.showvillageloc();
        }
    }
    public class villages
    {
        int distance = 0;
        String village_name = "";
        public villages(int dist, String villName)
            {
            distance = dist;
            village_name = villName;
            }
        public void showvillageloc()
        {
            Console.WriteLine(village_name+" is "+distance+" km away");
        }
    }
    class Countryside
    {
        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {
            Alst = new Village();
            Alst.VillageName = "Alst";
            Maeland = new Village();
            Maeland.VillageName = "Maeland";
            Maeland.isAstrildeHere = true;
            Schenig = new Village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }

        public void WalkAround()
        {
            Village CurrentVillage = this.Maeland;
            Village NextVillage;

            NextVillage = CurrentVillage.NextVillage;


        }
    }

    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
    }


class Program
{
static void Main(string[] args)
{
//Countryside c = new Countryside();
//c.run();
}
}

class LearningExperiment
{
public void run()
{
Village Toronto;
Toronto = new Village();
Village a, b, c;
Toronto.villageName = "version A";
a = Toronto;
Console.WriteLine(a.villageName);
Toronto = new Village();
Toronto.villageName = "version B";
b = Toronto;
Console.WriteLine(b.villageName);
Toronto = new Village();
Toronto.villageName = "version C";
c = Toronto;
Console.WriteLine(c.villageName);


}
}


class Village
{
public bool isAstrilde;
public Village nextVillage;
public Village prevVillage;
public string villageName;
}
class Countryside
{
Village Toronto, Maple, Ajax;

public void run()
{
Maple = new Village();
Toronto = new Village();
Ajax = new Village();
Maple.villageName = "Toronto";
Maple.nextVillage = Toronto;

}
}
}
}

