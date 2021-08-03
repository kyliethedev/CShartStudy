using System;

namespace CSharpStudy
{
    class DelegateClass
    {
        private delegate void RunDelegate(int i);

        private void RunThis (int val) {
            Console.WriteLine("RunThis : " + val);
        }

        private void RunThat (int val) {
            Console.WriteLine("RunThat : " + val);
        }

        public void Perform() {
            RunDelegate run = new RunDelegate(RunThis);
            run(1024);

            run = RunThat;
            run(1024);
        }
    }
}