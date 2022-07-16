namespace PP01LineComparisonAssign
{  /// <summary>
   /// UC1 : Calculate length of line based on a point consisting of (x, y) co-ordinates using the Cartesian system
   /// </summary>
    internal class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Start(x1, y1) and End-point(x2,y2) co-ordinates of Line : ");
            Console.Write("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //Calculating length of line
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of line have co-ordinates ({0},{1}) and ({2},{3}) is : {4} ", x1, y1, x2, y2, length); //printing the length
        }
    }
}