using Laba2_2_2;
class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Введіть координати дрикутника:");
        Console.Write("x1: "); string x1 = Console.ReadLine(); int X1 = Convert.ToInt32(x1);
        Console.Write("y1: "); string y1 = Console.ReadLine(); int Y1 = Convert.ToInt32(y1);
        Console.Write("x2: "); string x2 = Console.ReadLine(); int X2 = Convert.ToInt32(x2);
        Console.Write("y2: "); string y2 = Console.ReadLine(); int Y2 = Convert.ToInt32(y2);
        Console.Write("x3: "); string x3 = Console.ReadLine(); int X3 = Convert.ToInt32(x3);
        Console.Write("y3: "); string y3 = Console.ReadLine(); int Y3 = Convert.ToInt32(y3);

        ICalculatingFigureProperties triangle = new Triangle(X1, Y1, X2, Y2, X3, Y3);
        Console.WriteLine("_______________________________");
        Console.WriteLine("Введіть:");
        Console.WriteLine("perimetr: знаходження периметра");
        Console.WriteLine("square:   знаходження площа");
        Console.WriteLine("stop:     зупинення програми");
        while (true)
        {
            string input1 = Console.ReadLine();
            if (input1 == "perimetr")
            {
                Console.WriteLine(Math.Round(triangle.Perimeter,2, MidpointRounding.AwayFromZero));
            }
            if (input1 == "square")
            {
                Console.WriteLine(Math.Round(triangle.Square(), 2, MidpointRounding.AwayFromZero));
            }
            if (input1 == "stop")
            {
                break;
            }
        }


        Console.Write("Введіть радіус кола:");
        string radius = Console.ReadLine();
        int radiusInt = Convert.ToInt32(radius);
        ICalculatingFigureProperties circle = new Circle(radiusInt);
        Console.WriteLine("_______________________________");
        Console.WriteLine("Введіть:");
        Console.WriteLine("perimetr: знаходження периметра");
        Console.WriteLine("square:   знаходження площа");
        Console.WriteLine("stop:     зупинення програми");

        
        while(true)
        {
            string input2 = Console.ReadLine();
            if (input2 == "perimetr")
            {
                Console.WriteLine(Math.Round(circle.Perimeter, 2, MidpointRounding.AwayFromZero));
            }
            if (input2 == "square")
            {
                Console.WriteLine(Math.Round(circle.Square(), 2, MidpointRounding.AwayFromZero));
            }
            if(input2 == "stop")
            {
                break;
            }
        }

    }
}