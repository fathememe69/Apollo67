using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo67
{
    internal class Speszsip
    {
        public string Name;
        public double Hull;
        public double Shield;
        public int Fuel;
        public string EngineType { get; set; }
        public int fuelNeeded { get; set
            {
                if (EngineType == "efficient")
                {
                    value /= 2;
                }
            } }
        public int CrewCount { get
            {
                return astronautsOnBoard.Count;
            }
                }
        public List<Astronaut> astronautsOnBoard;

        public Speszsip(string name, double hull, double shield, int fuel, string enginetype, List<Astronaut> astronauts)
        {
            Name = name;
            Hull = hull;
            Shield = shield;
            Fuel = fuel;
            astronautsOnBoard = astronauts;
            EngineType = enginetype;
        }

        public Speszsip(string name, double hull, double shield, int fuel)
        {
            Name = name;
            Hull = hull;
            Shield = shield;
            Fuel = fuel;
            
        }

        public void ShowStatus()
        {
            Console.WriteLine($"{Name} Szpészsip adatai: \n Név: {Name} \n Hull: {Hull} \n Shield: {Shield} \n Fuel: {Fuel}");
        }

        public void Travel()
        {
            if ( Fuel < 20)
            {
                Console.WriteLine("Nincs elég üzemanyag az utazáshoz.");
            }
            else
            {
                Fuel -= 20;
                Console.WriteLine($"Az {Name} utazik.");
            }
            

        }

        public void Repair()
        {
            Hull += 25;
            Console.WriteLine("A hajó javítása folyamatban....");
        }

        public void TakeDamage()
        {
            Shield -= 30;
            Hull -= 20;
            Console.WriteLine("Találat érte a hajót!");
        }

        public void Diagnostics()
        {
            if (Hull < 20 && Shield < 20 || Hull < 20 && Fuel < 10)
            {
                Console.WriteLine("EXTRÉM VÉSZHELYZET!");
                Repair();
            }
            if ( Hull < 30 && Shield < 30 && Fuel < 20)
            {
                Console.WriteLine("KRITIKUS VÉSZHELYZET!");
                Repair();
            }
            if ( Hull < 50 &&  Shield < 50)
            {
                Console.WriteLine("SÚLYOS SÉRÜLÉS!");
                Repair();
            }
            if (Fuel < 20 || Shield < 30) {
                Console.WriteLine("ERŐFORRÁS-FIGYELMEZTETÉS!");
            }
            else
            {
                Console.WriteLine("Minden hajórendszer megfelelően működik.");
            }
        }

        public void ShowLogo()
        {
            if (Hull < 20)
            {
                Console.WriteLine("Kritikus sérülés \n <:!!!:> \n <:!!!::> \n <::!!!::> \n <:::!!!::> \n <:::!!!:::> \n <::!!!:::> \n <::!!!::> \n <:!!!::> \n <:!!!:>");
            }

            if (Hull < 50)
            {
                Console.WriteLine("Sérült hajó \n <::!::> \n <::!:::> \n <:::!:::> \n <:::!::::> \n <::::!::::> \n <:::!::::> \n <:::!:::> \n <::!:::> \n <::!::>");
            }

           else { Console.WriteLine($"{Name} \n <:::::> \n <::::::> \n <:::::::> \n <::::::::> \n <:::::::::> \n <::::::::> \n <:::::::> \n <::::::> \n <:::::>"); }
            
        }

        public bool CanTravel(int distance)
        {
           
        }

    }
}
