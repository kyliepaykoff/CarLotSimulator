using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            Car toyota= new Car();
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            toyota.Make = "toyota";
            toyota.Model = "corolla";
            toyota.Year = 2020;
            toyota.IsDriveable = true;
            toyota.EngineNoise = "vroom";
            toyota.HonkNoise = "beep";



            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            var paulsMustang = new Car()
            {


             
                Make = "Ford",
                Model = "Mustang",
                Year = 2015,
                IsDriveable = true,
                EngineNoise = "BBBBRRRRMMMMMMMMMMMMBUMBUMBUMBUMBUMBUM",
                HonkNoise = "Brrrrrmp brrrrmp"





            };

            var dreamCar = new Car("Toyota", "Sequoia", 2024, true, "Vroooooooooom", "EHH EHH");







            //Set the properties for each of the cars
            //Call each of the methods for each car
            toyota.MakeEngineNoise();
            paulsMustang.MakeEngineNoise();
            dreamCar.MakeEngineNoise(); 
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console



        }
    }
}
