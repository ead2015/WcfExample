using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClientApplication.SR1;
namespace MyClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
           CarRentalServiceClient myClient = new CarRentalServiceClient();

            string message = myClient.GetData(13);
            Console.WriteLine("message  = "+ message);

            Car car = new Car();
            car.BoolValue = true;
            car.StringValue = "this is my car";

           Car mySecondCar= myClient.GetDataUsingDataContract(car);

           Console.WriteLine("Car String Value = "+ mySecondCar.StringValue);
           myClient.Close();
        }
    }
}
