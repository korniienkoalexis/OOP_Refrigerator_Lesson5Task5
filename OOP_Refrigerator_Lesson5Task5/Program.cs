using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Refrigerator_Lesson5Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRefrigerator frigo = new MyRefrigerator(true, FrostLevel.Low, false, false , "Samsung");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(frigo.Info() + "\n");
                Console.WriteLine("Press the button for manipulation:");
                Console.WriteLine("1 - Power ON");
                Console.WriteLine("2 - Power OFF");
                Console.WriteLine("3 - Open the door of refrigerator");
                Console.WriteLine("4 - Close the door of refrigerator");
                Console.WriteLine("5 - Open the frost door");
                Console.WriteLine("6 - Close the frost door");
                Console.WriteLine("O - Turn OFF  the frost");
                Console.WriteLine("L - Ser Low volume of frost");
                Console.WriteLine("M - Ser Meddium volume of frost");
                Console.WriteLine("H - Ser Higth volume of frost");
                Console.WriteLine("e - exit");

                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        frigo.RefrigeratorON();
                        break;
                    case '2':
                        frigo.RefrigeratorOFF();
                        break;
                    case '3':
                        frigo.RefrigeratDoorOpen();
                        break;
                    case '4':
                        frigo.RefrigeratDoorClose();
                        break;
                    case '5':
                        frigo.frostDoorStateOpen();
                        break;
                    case '6':
                        frigo.frostDoorStateClose();
                        break;
                    case 'o':
                        frigo.SetFrostLevelOFF();
                        break;
                    case 'l':
                        frigo.SetFrostLevelLOW();
                        break;
                    case 'm':
                        frigo.SetFrostLevelMiddle();
                        break;
                    case 'h':
                        frigo.SetFrostLevelHigh();
                        break;
                    case 'e':
                        return;
                }
            }
        }
    }
}
