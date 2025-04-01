//import - not nessesary for exam 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//python variables
// a=10

// c# variables
// data_type var_name = value; 
//int a = 10;


// class
public class Shape
{
    // properties
    string color;
    // syntax array
    int[] position;
    private string Password { get; set; }

    //public void Draw() { }
    //public void Draw(string color) { }

    //abstract method
    //public abstract void Draw ();

    //virtual method
    public virtual void Draw() { }
    public void CalculateArea() { }

}



public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}










/* 
 using System;

public abstract class Shape
{
    public string Color { get; set; }
    public double PositionX { get; set; }
    public double PositionY { get; set; }
    private string Password { get; set; }

    public Shape(string color, double positionX, double positionY, string password)
    {
        Color = color;
        PositionX = positionX;
        PositionY = positionY;
        Password = password;
    }

    public bool CheckPassword(string inputPassword)
    {
        return Password == inputPassword;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape...");
    }

    public virtual double CalculateArea()
    {
        return 0.0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double positionX, double positionY, double radius, string password)
        : base(color, positionX, positionY, password)
    {
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine("This is a circle.");
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("Red", 10, 20, 5, "secret123");

        string userPassword = "secret123";
        if (circle.CheckPassword(userPassword))
        {
            circle.Draw();
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            Console.WriteLine($"Color: {circle.Color}, Position: ({circle.PositionX}, {circle.PositionY})");
        }
        else
        {
            Console.WriteLine("Incorrect password! Access denied.");
        }
    }
}
 */