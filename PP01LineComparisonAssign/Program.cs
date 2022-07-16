namespace PP01LineComparisonAssign
{  /// <summary>
   /// UC2 : Check equality of two lines using Equals method 
   /// </summary>
    internal class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {   //Taking input for the Endpoints of Line 1
            Console.WriteLine("Enter the Start(x1, y1) and End-point(x2,y2) co-ordinates for Line 1 : ");
            Console.Write("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //Taking input for the Endpoints of Line 2
            Console.WriteLine("Enter the Start(x3,y3) and End-point(x4,y4) co-ordinates for Line 2  : ");
            Console.Write("x3 : ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3 : ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x4 : ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4 : ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            //Calculating length of line1 & Line2
            double length1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            double length2 = Math.Sqrt((Math.Pow((x4 - x3), 2)) + (Math.Pow((y4 - y3), 2)));

            bool value1 = length1.Equals(length2); //using Equals method to compare 2 lines

            //Selection statement
            if (value1 == true)
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }
    }
}