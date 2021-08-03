using System;

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

            Func<int, int> func = (x) => x * 2;
            Console.WriteLine("Lambda func : " + func(4));

            int actionResult = 0;
            Action<int> action = (x) => actionResult = x * 10;
            action(10);
            Console.WriteLine("Lambda action : " + actionResult);
        }
    }
}
