using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string que = "Favorite \"Color\"?";

            // // Console.WriteLine(que);
            //  string answer = Console.ReadLine();

            // // Console.WriteLine("your fav color is {0}", answer);
            // // Console.ReadLine();

            //  int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //  string[] strArr = new string[] { "ok", "yep", "1ok", "yea", "yeahh","yeahhh" };
            // // Console.WriteLine("{1}", strArr[0], strArr[1]);
            ////  Console.ReadLine();


            //  for (int i = 0; i < strArr.Length; i++)
            //  {
            //      string item = strArr[i];
            //      Console.WriteLine("{1}item....{0}",item, i);
            //  }



            //for (int i = 0; i <= 100; i++)
            
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
                
            //        if (i % 5 == 0)
            //        {
            //            Console.WriteLine("Buzz");
            //        }

            //        else
                    
            //            if (i % 3 == 0 && i % 5 == 0)
            //            {
            //                Console.WriteLine("FizzBuzz");
            //            }
            //            else
            //            {
            //                Console.WriteLine(i++);
            //            }

            //    }
            //FIZZ BUZZ
            //int[] name = new int[100];
            //for (int i = 1; i <= name.Length; i++)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine("Fizz");
            //    if (i % 5 == 0)
            //        Console.WriteLine("Buzz");
            //    if ((i % 3 == 0 &&i % 5 == 0))
            //        Console.WriteLine("FizzBuzz");
            //    if (!(i % 3 == 0 || i % 5 == 0))
            //        Console.WriteLine(i);

           // Console.Write(Environment.NewLine);
            //}

            string quote = "To whom much is given much is required";
            Console.WriteLine(quote);

            Console.ReadLine();

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            object[] objArr = new object [] {"Brittney","26",  "July 5th", "coding"};
            Console.WriteLine("My name is " + objArr[0] + ". I am " + objArr[1] + " and my birthday is " + objArr[2] + ". In my spare time I enjoy " + objArr[3]);
            Console.ReadLine();
            }
        }
  }
