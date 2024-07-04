using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1;
public interface IEngine
{
    void Start();
}

public class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

// public class Car
// {
//     private readonly IEngine _engine;

//     public Car(IEngine engine) // Phụ thuộc được truyền vào thông qua constructor
//     {
//         _engine = engine;
//     }

//     public void Drive()
//     {
//         _engine.Start();
//         Console.WriteLine("Car is driving.");
//     }
// }
public class Car
{
    public IEngine? Engine {get; set; }

    public void Move()
    {
        Engine?.Start();
        Console.WriteLine("Car is moving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
      IEngine engine = new Engine();
      Car car = new Car();
      car.Engine = engine;
      car.Move();
    }
}
