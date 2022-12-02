namespace SimpleGeometryCalc;

public class Program
{

//Class Platters, Lists

    public static List<Shape> Shapes = new List<Shape>();


//Main
    static void Main(string[] args)
    {

        string command = "";
            while(command !="exit")
            {
                Console.Clear();
                Console.WriteLine("Enter an available command: create, ... ");
                command = Console.ReadLine().ToLower();

                switch(command)
                {
                    case "create":
                        MakeShape();
                        break;
                }

            }

        
    }




//Classes, Objects

    public class Shape
    {

        public string Type {get;set;}

        public string Length {get;set;}
        public string Angle {get;set;}

        public string OtherAngle {get;set;}
        public string Height {get;set;}
        public string Diameter {get;set;}
        public string Perimeter {get;set;}
        public string Area {get;set;}

    }

    



//Methods, Actions

    private static void MakeShape()
    {
        Shape shape = new Shape();

        Console.WriteLine("Choose a shape: circle, triangle, or square?");
        shape.Type = Console.ReadLine().ToLower();
        
        
        if (shape.Type == "triangle")
        {
            CalcTriangle(shape);
            DisplayTriangle(shape);

            Console.WriteLine("Triangle Calculated. Press Key to return...\n");
            Console.ReadKey();
            
            return;

        }
        else if (shape.Type == "square")
        {
            

            CalcSquare(shape);
            DisplaySquare(shape);

            Console.WriteLine("Square Calculated. Press Key to return...\n");
            Console.ReadKey();
            
            return;
        }
        else if (shape.Type == "circle")
        {
            CalcCircle(shape);
            DisplayCircle(shape);

            Console.WriteLine("Circle Calculated. Press Key to return...\n");
            Console.ReadKey();
            
            return;
            
        }
        else
        {
            Console.WriteLine("Shape Not Recognized. Press Key to Continue...\n");
            Console.ReadKey();
            
            return;
        }

        


    }

    private static void CalcTriangle(Shape shape)
    {
        double arm1;
        double arm2;
        double hypotenuse;
        double angle1;
        double area;
        double perimeter;


        Console.WriteLine("Enter Base Length: ");
        shape.Length = Console.ReadLine();

        Console.WriteLine("Enter Angle Degree: ");
        shape.Angle = Console.ReadLine();

        //Console.WriteLine("Converting String to Double");

        arm1 = double.Parse(shape.Length);
        angle1 = double.Parse(shape.Angle);

        double angle2 = 180 - 90 - angle1;

        hypotenuse = Math.Abs(( (arm1) / (Math.Cos(angle1)) ));
Console.WriteLine("Hypotenuese = " + hypotenuse);        

        arm2 = (Math.Sqrt((hypotenuse*hypotenuse) - (arm1*arm1)));
Console.WriteLine("arm2 = " + arm2);
        //Could put next two vars in a list and use a loop to convert them into strings

        perimeter = arm1 + arm2 + hypotenuse;
        area = 0.5 * arm1 * arm2;

        string angle2String = angle2.ToString();
        string arm2String = arm2.ToString();
        string perimeterString =  perimeter.ToString();
        string areaString = area.ToString();


        int angle2Count = angle2String.Count();
        int perimeterCount = perimeterString.Count();
        int areaCount = areaString.Count();
        int arm2Count = arm2String.Count();
        angle2String = angle2String.Substring(0, angle2Count);
        arm2String = arm2String.Substring(0, arm2Count);
        perimeterString = perimeterString.Substring(0, perimeterCount);
        areaString = areaString.Substring(0, areaCount);

        shape.OtherAngle = angle2String;
        shape.Height = arm2String;
        shape.Perimeter = perimeterString;
        shape.Area = areaString;

    }

    private static void CalcSquare(Shape shape)
    {
        Console.WriteLine("Enter Base Length: ");
        shape.Length = Console.ReadLine();

        double side1 = double.Parse(shape.Length);

        double perimeter = side1 * 6;
        double area = side1 * side1;

        string perimeterString = perimeter.ToString();
        string areaString = area.ToString();

        int perimeterCount = perimeterString.Count();
        int areaCount = areaString.Count();
        shape.Perimeter = perimeterString.Substring(0, perimeterCount);
        shape.Area = areaString.Substring(0, areaCount);
    }

    private static void CalcCircle(Shape shape)
    {
        Console.WriteLine("Enter Radius: ");
        shape.Length = Console.ReadLine();
        
        
        double radius = double.Parse(shape.Length);

        double diameter = 2 * radius;

        double circumference = Math.PI * 2 * radius;
        double area = Math.PI * radius * radius;

        string diameterString = diameter.ToString();
        string circumferenceString = circumference.ToString();
        string areaString = area.ToString();

        int diameterCount = diameterString.Count();
        int circumferenceCount = circumferenceString.Count();
        int areaCount = areaString.Count();
        shape.Diameter = diameterString.Substring(0, diameterCount);
        shape.Perimeter = circumferenceString.Substring(0, circumferenceCount);
        shape.Area = areaString.Substring(0, areaCount);
    }

    private static void DisplayCircle(Shape shape)
    {
        Console.WriteLine(" Shape: " + shape.Type);
        Console.WriteLine(" Radius: " + shape.Length);
        Console.WriteLine(" Diameter: " + shape.Diameter);
        Console.WriteLine(" Circumference: " + shape.Perimeter);
        Console.WriteLine(" Area: " + shape.Area);
        Console.WriteLine("\n");
    }


    private static void DisplayTriangle(Shape shape)
    {
        Console.WriteLine(" Shape: " + shape.Type);
        Console.WriteLine(" Base Length: " + shape.Length);
        Console.WriteLine(" Angle: " + shape.Angle);
        Console.WriteLine(" Other Angle: " + shape.OtherAngle);
        Console.WriteLine(" Height: " + shape.Height);
        Console.WriteLine(" Perimeter: " + shape.Perimeter);
        Console.WriteLine(" Area: " + shape.Area);
        Console.WriteLine("\n");
    }

    private static void DisplaySquare(Shape shape)
    {
        Console.WriteLine(" Shape: " + shape.Type);
        Console.WriteLine(" Base Length: " + shape.Length);
        Console.WriteLine(" Perimeter: " + shape.Perimeter);
        Console.WriteLine(" Area: " + shape.Area);
        Console.WriteLine("\n");
    }

    

}

