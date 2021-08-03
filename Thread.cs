using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStudy 
{
    public class ThreadClass
    {
        public void DoSomething() {
            for (int i = 0 ; i < 5; i++) {
                Console.WriteLine("ThreadClass DoSomething : " + i);
                Thread.Sleep(10);
            }
        }

        async private void MyMethodAsync(int count) {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async() => {
               for (int i = 1 ; i <= count; i++) {
                   Console.WriteLine("MyMethodAsync : " + i);
                   await Task.Delay(100);
               } 
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        public void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }
    }
}