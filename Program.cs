public class Program{
    static void Main(string[] args){
        Car myCar = new Car();
        myCar.band = "Toyota";
        myCar.model = "Altis";
        myCar.numberOfDoors = 4;
        myCar.numberOfWheels = 4;

        Car mcar = new Car();
        mcar.band = "A";
        mcar.model = "B";
        mcar.numberOfDoors = 4;
        mcar.numberOfWheels = 4;

        PrintCarInformation(myCar);
        PrintCarInformation(mcar);
    }
    static void PrintCarInformation(Car car){
        Console.WriteLine("***************");
        Console.WriteLine("Band : {0}", car.band);
        Console.WriteLine("Model : {0}", car.model);
        Console.WriteLine("Number of doors : {0}", car.numberOfDoors);
        Console.WriteLine ("Number of wheels : {0}", car.numberOfWheels);
        Console.WriteLine(car.MoveForward());
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.Stop());
        Console.WriteLine(car.Turn());
        Console.WriteLine("***************");
    }
}



