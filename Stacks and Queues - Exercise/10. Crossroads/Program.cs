using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            //секунди на зеления светофар
            int secondsFreeCrossroad = int.Parse(Console.ReadLine());
            //секунди на"свободното пресичане"

            Queue<string> cars = new Queue<string>();
            //опашка с колите
            int totalCarsPassed = 0;
            //брой на успешно преминалите коли на светофара
            while (true)
            {
                string input = Console.ReadLine();
                //четем инпута
                int greenLights = greenLightSeconds;
                int freeSeconds = secondsFreeCrossroad;
                //тези 2 променливи са помощни, за да не разваляме оригиналните за сравнение 

                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    return;
                    //тук всички коли са преминали успешно
                }
                else if (input == "green")
                {
                    //светофара е в зелено=> колите започват да преминават
                    while (greenLights > 0 && cars.Any())
                    {
                        //колите ще минават докато светофара има още секунди
                        // и изобщо докато има още коли в опашката
                        string firstCar = cars.Peek();
                        //взимаме първата кола в опашката
                        greenLights -= firstCar.Length;
                        //от скундите на зеления светофар вадим дължината на колата
                        if (greenLights >= 0)
                        {
                            //ако секундите са стигнали или са станали 0 имаме успешно преминаване на колата
                            totalCarsPassed++;
                            //премахваме я от опашката щом е преминала
                            cars.Dequeue();
                        }
                        else
                        {
                            //ако секундите на зеления светофар не са стигнали,
                            //прибавяме секундите на свободното пресичане
                            freeSeconds += greenLights;

                            if (freeSeconds < 0)
                            {
                                //ако и тези секунди не ни стигнат=>катастрофа
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{firstCar} was hit at {firstCar[firstCar.Length + freeSeconds]}.");
                                return;
                            }
                            //в противен случай, колата преминава
                            // и я махаме от опащката
                            totalCarsPassed++;
                            cars.Dequeue();


                        }
                    }
                }
                else
                {
                    //ако инпута не е нито енд, нито зелено
                    //прибавяме новата кола към опашката
                    cars.Enqueue(input);
                }

            }
        }
    }
}
