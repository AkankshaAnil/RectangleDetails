using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
        class operation
        {
            static void Main(string[] args)
            {
                int Value1, Value2;
                Console.WriteLine("please enter the Value1");
                Value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter the Value2");
                Value2 = Convert.ToInt32(Console.ReadLine());
                int Result;
                Result = Value1 + Value2;
                Console.WriteLine("Sum of two Values:" + Result.ToString());
                
         Rectangle r = new Rectangle();
                r.Acceptdetails();
                r.Display();
            }
        }
    }

