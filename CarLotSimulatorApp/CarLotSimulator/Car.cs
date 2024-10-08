using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; } = true;
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

       

        

        public Car(string make, string model, int year, bool isDriveable, string engineNoise, string honkNoise)
        {
            Make = make;
            Model = model;  
            Year = year;    
            IsDriveable = isDriveable;  
            EngineNoise = engineNoise;  
            HonkNoise = honkNoise;

            CarLot.numberOfCars++;



        }
          





       

        public void MakeEngineNoise()
        {

            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }



       

    }





}
