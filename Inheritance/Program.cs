using Inheritance.Inheritance;

namespace Inheritance
{
     class Program
    {
        static void Main(string[] args)
        {
            //Q-1
            //Car car = new Car();
            //car.Brand = "Toyota";
            //car.Speed = 100;
            //System.Console.WriteLine(car.DisplayInfo());
            //Bike bike = new Bike();
            //bike.Brand = "Yamaha";
            //bike.Speed = 50;
            //string bikeInfo = bike.DisplayInfo();
            //System.Console.WriteLine(bikeInfo);

            //Q-2
            //Car2 car = new Car2();
            //car.brand = "Toyota";
            //car.speed = 100;
            //System.Console.WriteLine(car.DisplayCarInfo());
            //Bike2 bike = new Bike2();
            //bike.brand = "Yamaha";
            //bike.speed = 50;
            //string bikeInfo = bike.DisplayBikeInfo();
            //System.Console.WriteLine(bikeInfo);

            //Q-3
            //Manager manager = new Manager("John", 50000, 10000);
            //System.Console.WriteLine($"Name: {manager.Name}, Salary: {manager.Salary}, Bonus: {manager.Bonus}");
            //Employee employee = new Employee("Jane", 30000);
            //System.Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");

            //Q-4
            // Dog dog = new Dog();
            //Console.WriteLine(dog.MakeSound());
            //Cat cat = new Cat();
            //Console.WriteLine(cat.MakeSound());

            //Q-5
            //Robot robot = new Robot();
            //robot.Start();
            //robot.Move();
            //Machine machine = new Machine();
            //machine.Start();

            //Q-6
            //Account acc = new SavingsAccount();
            //acc.CalculateInterest(); // Calls the overridden method in SavingsAccount

            //Q-7
            //Duck duck = new Duck();
            //duck.Fly();
            //duck.Swim();

            //Q-8
            //  // Create a Student object
            //  Student student = new Student("John Doe", 20, 12345);
            // // Upcast Student to Person
            //  Person person = student;
            //// Downcast Person back to Student
            // Student downcastedStudent = (Student)person;
            //// Display information
            // downcastedStudent.DisplayStudent();

            //Q-9
            ElectronicProduct electronicProduct = new ElectronicProduct();
            electronicProduct.GetDiscount();


        }
    }
}
