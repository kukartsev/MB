using Geometry;
using Geometry.BaseFigures;

try
{ 
    GeometricCalculator calculator = new GeometricCalculator();
    Console.WriteLine($"Circle with radius 9. And its area is {calculator.CalculateArea(new Circle(9))}");
    Console.WriteLine($"Trangle with sides 3,4,5. And its area is {calculator.CalculateArea(new Triangle(3, 4, 5))}");
    if (new Triangle(3, 4, 5).IsRight)
    {
        Console.WriteLine("Trangle with sides 3,4,5 is right");
    }
    Console.WriteLine($"Trangle with sides 2,4,6. And its area is {calculator.CalculateArea(new Triangle(2, 4, 6))}");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}

Console.ReadKey();
