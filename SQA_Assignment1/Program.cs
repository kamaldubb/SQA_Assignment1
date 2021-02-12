using System;

namespace SQA_Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());
            while (length <= 0)
            {
                Console.WriteLine("Please Re-enter the length of rectangle which must be greater than 0:");
                length = Convert.ToInt32(Console.ReadLine());
                if (length > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Enter the width of rectangle:");
            int width = Convert.ToInt32(Console.ReadLine());

            while (width <= 0)
            {
                Console.WriteLine("Please Re-enter the width of rectangle which must be greater than 0:");
                width = Convert.ToInt32(Console.ReadLine());
                if (width > 0)
                {
                    break;
                }
            }
            Rectangle rec = new Rectangle(length, width);
            int b = 1;
            while (b < 7)
            {
                Console.WriteLine("Select from the following menu to perform any operation");
                Console.WriteLine("Press 1 to Get Rectangle Length");
                Console.WriteLine("Press 2 to Change Rectangle Length");
                Console.WriteLine("Press 3 to Get Rectangle Width");
                Console.WriteLine("Press 4 to Change Rectangle Width");
                Console.WriteLine("Press 5 to Get Rectangle Perimeter");
                Console.WriteLine("Press 6 to Get Rectangle Area");
                Console.WriteLine("Press 7 to  Exit the Apllication");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i <= 0)
                {
                    Console.WriteLine("Please enter a value that must be greater than 0:");
                    Console.WriteLine("Select from the following menu to perform any operation");
                    Console.WriteLine("Press 1 to Get Rectangle Length");
                    Console.WriteLine("Press 2 to Change Rectangle Length");
                    Console.WriteLine("Press 3 to Get Rectangle Width");
                    Console.WriteLine("Press 4 to Change Rectangle Width");
                    Console.WriteLine("Press 5 to Get Rectangle Perimeter");
                    Console.WriteLine("Press 6 to Get Rectangle Area");
                    Console.WriteLine("Press 7 to  Exit the Apllication");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" ");
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Length of Rectangle is: " + rec.GetLength());
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        Console.WriteLine("Enter the new length of rectangle");
                        int le = Convert.ToInt32(Console.ReadLine());
                        if (le <= 0)
                        {
                            Console.WriteLine("Enter the new length of rectangle which must be greater than zero");
                            le = Convert.ToInt32(Console.ReadLine());
                        }
                        rec.SetLength(le);
                        Console.WriteLine(" ");
                        break;

                    case 3:
                        Console.WriteLine("Width of Rectangle is: " + rec.GetWidth());
                        rec.GetWidth();
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        Console.WriteLine("Enter the new width of rectangle");
                        int wd = Convert.ToInt32(Console.ReadLine());
                        if (wd <= 0)
                        {
                            Console.WriteLine("Enter the new width of rectangle which must be greater than zero");
                            wd = Convert.ToInt32(Console.ReadLine());
                        }
                        rec.SetWidth(wd);
                        Console.WriteLine(" ");
                        break;
                    case 5:

                        int p = rec.GetPerimeter();
                        Console.WriteLine("Perimeter of rectangle is: " + p);
                        Console.WriteLine(" ");
                        break;
                    case 6:

                        int a = rec.GetArea();
                        Console.WriteLine("Area of rectangle is: " + a);
                        Console.WriteLine(" ");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }



        }
    }
}
