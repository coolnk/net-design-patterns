using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carCatalog = new CarCatalog(3);
            carCatalog.Add(new Car { Color = "Yellow",HorsePower="120hp", Model="Ford-T" });
            carCatalog.Add(new Car { Color = "Red",HorsePower="200hp", Model="Lamboughini" });
            carCatalog.Add(new Car { Color = "Blue",HorsePower="200hp", Model= "Fiat" });

            IEnumerator<Car> carEnumerator = carCatalog.GetEnumerator();
            //while(carEnumerator.MoveNext()) {
            //    Console.WriteLine(carEnumerator.Current.ToString());  
            //}
            foreach(Car car in carCatalog) {
                Console.WriteLine(car.Model);
            }
        
            Console.ReadKey();

}
    }
}
