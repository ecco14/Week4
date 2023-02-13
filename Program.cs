using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Rectangle
    {

        
        

        static void Main(string[] args)
        {

            int length = randomlength();

            int width = randomwidth();

            int area = matharea(length, width);

            int peremeter = mathpere(length, width);

            string len = Convert.ToString(length);
            string wid = Convert.ToString(width);
            string ar = Convert.ToString(area);
            string pere = Convert.ToString(peremeter);

            

            output(len, wid, ar, pere);


        }

        public static int randomlength()
        {
            Random rnd = new Random();
            int length = rnd.Next(1, 21);

            return length;
            


        }

        public static int randomwidth()
        {
            Random rnd = new Random();
            int width = rnd.Next(1, 11);

            return width;
        }

        public static int matharea(int length, int width)
        {

            int area = length * width;

            return area;
        }

        static int mathpere(int length, int width)
        {
            int peremeter = 2 * (length + width);

            return peremeter;
        }


        static void output(string len, string wid, string ar, string pere)
        {
            Console.WriteLine("Length: " + len);
            Console.WriteLine("Width: " + wid);
            Console.WriteLine("Area: " + ar);
            Console.WriteLine("Peremeter: " + pere);


        }  
            
    }

}
