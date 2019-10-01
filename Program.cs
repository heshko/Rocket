using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Rocket_Simulator
{
    class Program
    {

        static void Main(string[] args)
        {
            Rocket Rocket1 = new Rocket();
            Rocket Rocket2 = new Rocket();
            Rocket[] rocket = new Rocket[10];
            bool shouldRun = true;
            rocket[0] = Rocket1;
            rocket[1] = Rocket2;
            while (shouldRun)
            {
                Clear();
                WriteLine("1. Add rocket");
                WriteLine("2. List rockets");
                WriteLine("3. Run simulation");
                WriteLine("4. Exit");
                ConsoleKeyInfo input = ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Clear();
                        string rocket1 = "1.Starship, SpaceX";
                        string rocket2 = "2.Heavy Falcon, SpaceX";
                        WriteLine(rocket1);
                        WriteLine(rocket2);



                        ConsoleKeyInfo input1 = ReadKey();
                                
                   
                        {
                            switch (input1.Key)
                            {
                                case ConsoleKey.D1:
                                    if (rocket[0].rocketName == null)
                                    {
                                        rocket[0].rocketName = rocket1;
                                        Clear();

                                        WriteLine("Rocket added");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Rocket already added");
                                    }


                                    break;
                                case ConsoleKey.D2:
                                    if(rocket[1].rocketName == null){
                                        rocket[1].rocketName = rocket2;
                                        Clear();

                                        WriteLine("Rocket added");
                                    }
                                    else
                                    {
                                        Clear();
                                        WriteLine("Rocket already added");
                                    }


                                    break;
                            }
                        }
                   
                        Thread.Sleep(1000);
                        Clear();
                        break;
                    case ConsoleKey.D2:
                        Clear();
                        WriteLine("Simulated rockets");
                        WriteLine("----------------------------");

                        for (int x = 0; x < 2; x++)
                        {

                            if (rocket[x].rocketName != null)
                            {
                                WriteLine(rocket[x].rocketName);
                            }

                        }

                        ReadKey();
                        break;
                    case ConsoleKey.D3:

                        Clear();
                        Write("Engine burn period (sec): ");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        string nameRocket = "Rocket";
                        string Velocity = "   Velocity(km / s)";
                        string Fuel = " Fuel left(tons)";

                        WriteLine(nameRocket.PadLeft(0)+Velocity.PadLeft(25)+Fuel.PadLeft(35));
                        WriteLine("------------------------------------------------------------------");

                       
                            if (rocket[0].rocketName != null)
                            {
                                WriteLine(rocket[0].rocketName.ToString().PadLeft(0) + (sec / 0.4).ToString().PadLeft(25) + (sec * 35.8).ToString().PadLeft(25));
                            }
                            if (rocket[1].rocketName != null)
                            {
                            WriteLine(rocket[1].rocketName.ToString().PadLeft(0) + (sec / 0.4).ToString().PadLeft(21) + (sec * 35.8).ToString().PadLeft(25));
                            }
                        WriteLine("<Press key to continue>");

                        ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Clear();
                        WriteLine("BYe BYe");
                        Thread.Sleep(2000);
                        shouldRun = false;
                        break;
                }
            }

        }
    }
    class Rocket
    {
        public string rocketName;
    }
}
