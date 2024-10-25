namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a Car object
            Car car = new Car();


            //Set the properties of the car object
            car.Brand = "Ford";
            car.Model = "Focus";
            car.DoorCount = 3;
            car.Color = "Red";

            //Display the properties of the car object
            car.showCarInfo();
        }
    }
}
