using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Apollo67
{
    internal class Spacesuit
    {
        public string Model;
        public int OxygenLevel;
        public double Integrity;

        public Spacesuit(string model, int oxygenlevel, double integrity)
        {
            Model = model;
            OxygenLevel = oxygenlevel;
            Integrity = integrity;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"{Model} Spacesuit adatai: \n Model: {Model} \n OxygenLevel: {OxygenLevel} \n Integrity: {Integrity}");
        }
    }
}
