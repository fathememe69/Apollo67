namespace Apollo67
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Speszsip apollo67 = new Speszsip("Apollo 67", 100, 80, 90);
      
            Console.WriteLine($"{apollo67.Name} szpészsip adatai: \n Név: {apollo67.Name} \n Hull: {apollo67.Hull} \n Shield: {apollo67.Shield} \n Fuel: {apollo67.Fuel}");
            Console.WriteLine();

            apollo67.Hull = 75;
            apollo67.Fuel = 60;

            apollo67.ShowStatus();
            Console.WriteLine();

            apollo67.Fuel = 90;

            apollo67.Travel();
            Console.WriteLine($"A hajo üzemanyagot használt az utazás során új üzemanyagszint: \n Fuel: {apollo67.Fuel}");
            Console.WriteLine();


            apollo67.Travel();
            Console.WriteLine($"A hajo üzemanyagot használt az utazás során új üzemanyagszint: \n Fuel: {apollo67.Fuel}");
            Console.WriteLine();

            apollo67.Hull = 40;

            apollo67.Repair();
            Console.WriteLine($"A hajó javítása befejeződött új érték: \n Hull: {apollo67.Hull}");
            Console.WriteLine();

            apollo67.Repair();
            Console.WriteLine($"A hajó javítása befejeződött új érték: \n Hull: {apollo67.Hull}");
            Console.WriteLine();


            apollo67.Hull = 100;
            apollo67.Shield = 80;

            apollo67.TakeDamage();
            Console.WriteLine($"A hajót megsérítette a támadás Shieldet és Hullt vesztettél új értékek: \n Hull: {apollo67.Hull} \n Shield: {apollo67.Shield}");
            Console.WriteLine();

            apollo67.TakeDamage();
            Console.WriteLine($"A hajót megsérítette a támadás Shieldet és Hullt vesztettél új értékek: \n Hull: {apollo67.Hull} \n Shield: {apollo67.Shield}");
            Console.WriteLine();

            apollo67.Fuel = 10;

            apollo67.Travel();
            Console.WriteLine($"Fuel: {apollo67.Fuel}");
            Console.WriteLine();
  
           Spacesuit Kekruha = new Spacesuit("kekruha", 100, 80.2);
            Astronaut Csatai = new Astronaut("Csatai", 100, 80, 100, Kekruha);

            Spacesuit Pirosruha = new Spacesuit("pirosruha", 70, 90.1);
            Astronaut Ratonyi = new Astronaut("Ratonyi", 80, 40, 70, Pirosruha);


            Console.WriteLine($"Űrhajós1: \nName:{Csatai.Name} \nHealth:{Csatai.Health} \nEnergy:{Csatai.Energy} \nOxygen:{Csatai.Oxygen} ");
            Console.WriteLine($"Űrruha1: \nModel:{Kekruha.Model} \nOxygenLevel:{Kekruha.OxygenLevel} \nEnergy:{Kekruha.Integrity} ");
            Console.WriteLine();
            Console.WriteLine($"Űrhajós2: \nName:{Ratonyi.Name} \nHealth:{Ratonyi.Health} \nEnergy:{Ratonyi.Energy} \nOxygen:{Ratonyi.Oxygen} ");
            Console.WriteLine($"Űrruha2: \nModel:{Pirosruha.Model} \nOxygenLevel:{Pirosruha.OxygenLevel}  \nEnergy: {Pirosruha.Integrity} ");
            Console.WriteLine();

            Csatai.ShowStatus();
            Console.WriteLine();
            Ratonyi.ShowStatus();

            List<Astronaut> astronautList = new List<Astronaut>();
            astronautList.Add(Csatai);
            astronautList.Add(Ratonyi);


            Speszsip apollo69 = new Speszsip("Apollo 69", 100, 80, 90, astronautList);

            foreach (Astronaut a in apollo69.astronautsOnBoard )
            {
                a.ShowStatus();
            }

            

            Console.ReadLine();
            
        }
    }
}
