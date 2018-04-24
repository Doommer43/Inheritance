using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeEntities;

namespace ShapeManualTest
{
    class Program
    {
        static List<Shape> Shapes = new List<Shape>();
        public static bool EndLoop { get; set; }
        static void Main(string[] args)
        {
            
            while (EndLoop == false)
            {
                Console.WriteLine("To create a new shape type: circle --> 'c', rectangle --> 'r', square --> 's'");
                Console.WriteLine("For further options type 'i'");
                ConsoleKeyInfo Input = Console.ReadKey();
                Console.WriteLine();
                switch (Input.Key)
                {
                    //Creates a circle based on user input
                    case ConsoleKey.C:
                        Console.WriteLine("To create a circle please specify a radius in [UNIT].");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Coordinates for object -(x,y)");
                        Console.Write(value: "X-coord: ");
                        int cx = Int32.Parse(Console.ReadLine());
                        Console.Write(value: "Y-coord: ");
                        int cy = Int32.Parse(Console.ReadLine());
                        Circle circ = CreateCircle(cx, cy, r);
                        Console.WriteLine("Circle created.");
                        Console.WriteLine(circ.ToString());
                        break;
                    //Creates a rectangle based on user input
                    case ConsoleKey.R:
                        Console.WriteLine("To create a rectangle please specify a length and width in [UNIT].");
                        Console.Write("Length: ");
                        double l = double.Parse(Console.ReadLine());
                        Console.Write("Width: ");
                        double w = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Coordinates for object -(x,y)");
                        Console.Write(value: "X-coord: ");
                        int rx = Int32.Parse(Console.ReadLine());
                        Console.Write(value: "Y-coord: ");
                        int ry = Int32.Parse(Console.ReadLine());
                        Rectangle rect = CreateRectangle(rx, ry, l, w);
                        Console.WriteLine("Rectangle created.");
                        Console.WriteLine(rect.ToString());
                        break;
                    //Creates a square based on user input
                    case ConsoleKey.S:
                        Console.WriteLine("To create a square please specify a length in [UNIT].");
                        Console.Write("Length: ");
                        double sl = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Coordinates for object -(x,y)");
                        Console.Write(value: "X-coord: ");
                        int sx = Int32.Parse(Console.ReadLine());
                        Console.Write(value: "Y-coord: ");
                        int sy = Int32.Parse(Console.ReadLine());
                        Square square = CreateSquare(sx, sy, sl);
                        Console.WriteLine("Square created.");
                        Console.WriteLine(square.ToString());
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("To get the total number of shapes type '1'");
                        Console.WriteLine("To get the total number of circles type '2'");
                        Console.WriteLine("To get the total number of rectangles type '3'");
                        Console.WriteLine("To get the total number of squares type '4'");
                        Console.WriteLine("To get the total area of the shapes type '5'");
                        Console.WriteLine("To get the total circumference type '6'");

                        Input = Console.ReadKey();
                        Console.Clear();
                        switch (Input.Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine($"There are {GetNumberOfShapes()} shape(s)");
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine($"There are {GetNumberOfCircles()} circle(s)");
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine($"There are {GetNumberOfRectangles()} rectangle(s)");
                                break;
                            case ConsoleKey.D4:
                                Console.WriteLine($"There are {GetNumberOfSquares()} square(s)");
                                break;
                            case ConsoleKey.D5:
                                Console.WriteLine($"The total area is {GetTotalArea()}");
                                break;
                            case ConsoleKey.D6:
                                Console.WriteLine($"The total area is {GetTotalCircumference()}");
                                break;
                            default:
                                Console.WriteLine("No match. Exiting process");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("No shape matched that input. Exiting process.");
                        break;
                }

                Console.WriteLine("Do you wish to start over? Y/N");
                Input = Console.ReadKey();
                if (Input.Key == ConsoleKey.N)
                {
                    EndLoop = true;
                }
                Console.Clear();
            }
            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }

        public static int GetNumberOfSquares()
        {
            int Square = 0;
            foreach (Shape s in Shapes)
            {
                if (s is Square)
                {
                    Square++;
                }
            }
            return Square;
        }
        public static int GetNumberOfRectangles()
        {
            int rect = 0;
            foreach (Shape s in Shapes)
            {
                if (s is Rectangle && !(s is Square))
                {
                    rect++;
                }
            }
            return rect;
        }
        public static int GetNumberOfCircles()
        {
            int Circ = 0;
            foreach (Shape s in Shapes)
            {
                if(s is Circle)
                {
                    Circ++;
                }
            }
            return Circ;
        }
        public static int GetNumberOfShapes()
        {
            return Shapes.Count();
        }
        public static double GetTotalArea()
        {
            double Area = 0;
            foreach (Shape s in Shapes)
            {
                Area += s.CalculateArea();
            }

            return Area;
        }
        public static double GetTotalCircumference()
        {
            double cir = 0;
            foreach (Shape s in Shapes)
            {
                cir += s.CalculateCircumference();
            }
            return cir;
        }
        public static Circle CreateCircle(int x, int y, double radius)
        {
            Circle c = new Circle(x, y, radius);
            Shapes.Add(c);
            return c;
        }
        public static Rectangle CreateRectangle(int x, int y, double length, double width)
        {
            Rectangle r = new Rectangle(x, y, length, width);
            Shapes.Add(r);
            return r;
        }
        public static Square CreateSquare(int x, int y, double length)
        {
            Square s = new Square(x, y, length);
            Shapes.Add(s);
            return s;
        }
    }
}
