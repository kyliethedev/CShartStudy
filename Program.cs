using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace CSharpStudy
{
   class Program
    {
        static void Main(string[] args)
        {
            // 13. Delegate
            // DelegateClass mc = new DelegateClass();
            // mc.Perform();

            // 14. Lambda
            // Calculate cal = (x, y) => x + y;
            // Console.WriteLine("Lambda cal : " + cal(10, 20));        

            // Concatenate concat = ( arr ) => {
            //                                     string result = "";
            //                                     foreach (string s in arr) 
            //                                         result += s;

            //                                     return result;
            //                                 };
            // Console.WriteLine("Lambda concat : " + concat(args));

            // Func<int, int> func = (x) => x * 2;
            // Console.WriteLine("Lambda func : " + func(4));

            // int actionResult = 0;
            // Action<int> action = (x) => actionResult = x * 10;
            // action(10);
            // Console.WriteLine("Lambda action : " + actionResult);

            // 15. LINQ
            // List<Market> markets = new List<Market>();
            // markets.Add(new Market(){ Fruits = "Apple", Price = 100 });
            // markets.Add(new Market(){ Fruits = "Banana", Price = 500 });
            // markets.Add(new Market(){ Fruits = "Kiwi", Price = 3500 });
            // markets.Add(new Market(){ Fruits = "DragonFruits", Price = 7000 });
            // markets.Add(new Market(){ Fruits = "Not For Sale", Price = int.MaxValue });

            // var result = from market in markets
            //              where market.Price < 5000
            //              select market;

            // foreach (Market el in result) {
            //     Console.WriteLine("LINQ Fruits : " + el.Fruits + " , Price : " + el.Price);
            // }

            // 16-1. Thread
            // ThreadClass threadClass = new ThreadClass();
            // Thread t1 = new Thread(new ThreadStart(threadClass.DoSomething));
            // Console.WriteLine("== Starting thread == ");
            // t1.Start();

            // for (int i = 0 ; i < 5 ; i ++) {
            //     Console.WriteLine("Main is working : " + i );
            //     Thread.Sleep(10);
            // }

            // Console.WriteLine("== Wating until thread stops == ");
            // t1.Join();

            // Console.WriteLine("== Finished ==");

            // 16-2. Async, Await
            ThreadClass threadClass = new ThreadClass();
            threadClass.Caller();

            Console.ReadLine(); //To Prevent dead of program.
        }
    }
}
