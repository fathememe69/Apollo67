using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo67
{
    internal class Astronaut
    {
        public string Name { get; set; }
        public int Health;
        public int Energy {  get; private set; }
        public double Oxygen;
        public Spacesuit Spacesuit;

        public Astronaut(string name, int health, double energy, double oxygen, Spacesuit spacesuit)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Oxygen = oxygen;
            Spacesuit = spacesuit;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"{Name} Asztronauta adatai: \n Név: {Name} \n Health: {Health} \n Energy: {Energy} \n Oxygen: {Oxygen}" + $"\n {Spacesuit.Model} adatai: \n Model: {Spacesuit.Model} \n OxygenLevel: {Spacesuit.OxygenLevel} \n Integrity: {Spacesuit.Integrity}");
        }

        public void Rest()
        {
            if (Energy < 20)
            {
                Energy += 40;
                Console.WriteLine("Sürgős pihenés szükséges.");
            }
            if (Energy < 60)
            {
                Energy += 30;
                Console.WriteLine("Az űrhajós pihen.");
            }
            else {
                Console.WriteLine("Nincs szükség pihenésre.");
            }
        }

        public void Work()
        {
            Energy -= 20;
            Oxygen -= 10;
            Console.WriteLine("Az űrhajós dolgozik");
        }

        public void AstroDiagnostics()
        {
            if (Health < 30 &&  Energy < 30 || Oxygen < 20 && Energy < 30)
            {
                Console.WriteLine("VÉSZHELYZETI REGENERÁLÓDÁS SZÜKSÉGES!");
                Rest();
            }

            if (Health < 30 && Oxygen < 50 )
            {
                Console.WriteLine("ORVOSI VÉSZHELYZET!");
                Rest();
            }
            if (Energy < 30)
            {
                Console.WriteLine("Az űrhajós kimerült.");
                Rest();
            }
            if (Oxygen < 30)
            {
                Console.WriteLine("FIGYELEM: Alacsony oxigénszint!");
            }
            else
            {
                Console.WriteLine("Az űrhajós készen áll!");
            }
        }
    }
}
