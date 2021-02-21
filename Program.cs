using System;

namespace tryConstructor
{
    class Thing
    {
        private string[] engine = new string[3];
        private string _temp;
        public Thing()
        {
            engine[0] = "N/A";
            engine[1] = "N/A";
            engine[2] = "N/A";
        }

        public void enterData()
        {
            Console.Write("Enter famyli engine: ");
            _temp = Console.ReadLine();
            if (!string.IsNullOrEmpty(_temp))
            {
                engine[0] = _temp;
            }

            Console.Write("Enter PN engine: ");
            _temp = Console.ReadLine();
            if (!string.IsNullOrEmpty(_temp))
            {
                engine[1] = _temp;
            }

            Console.Write("Enter SN engine: ");
            _temp=Console.ReadLine();
            if (!string.IsNullOrEmpty(_temp))
            {
                engine[2] = _temp;
            }
        }
        public void prosessingData()
        {
            //Enter data to data base.
        }

        public void writeData()
        {   
            //Reading data from data base.

            Console.WriteLine($"Famyli engine: {engine[0]}");
            Console.WriteLine($"PN engine: {engine[1]}");
            Console.WriteLine($"SN engine: {engine[2]}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thing e1 = new Thing();

            e1.enterData();
            e1.prosessingData();
            e1.writeData();
        }
    }
}
