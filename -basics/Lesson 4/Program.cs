namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------Homework------
            * 1) get from console 3 int numbers
            * 2) using "if" choose the biggest
            * 3) outpot to console
            * 4) check on parity using "switch"
            * 5) check if < 100 using fast check
            */

            //1)
            Console.WriteLine("Please, write 3 numbers: \n");
            int Input1 = int.Parse(Console.ReadLine());
            int Input2 = int.Parse(Console.ReadLine());
            int Input3 = int.Parse(Console.ReadLine());
            //2)
            int Biggest = Input1;
            if (Input2 > Biggest) Biggest = Input2;
            if (Input3 > Biggest) Biggest = Input3;
            //3)
            Console.WriteLine($"The biggest number is {Biggest}");
            Console.ReadLine();
            //4)
            switch (Biggest % 2)
            {
                case 0:
                    Console.WriteLine("There is even number");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("There if odd number");
                    Console.ReadLine();
                    break;
            }
            //5)
            Console.WriteLine(Biggest < 100 ? "The number is less than 100" : "The number is more or equals 100");
            Console.ReadLine();






            //------Lesson------


            int Input = int.Parse(Console.ReadLine());
            /*if (Input < 10)
            {
                if (Input > 0)
                {
                    Console.WriteLine("Bigger");
                }
            }
            */

            Better to avoid this, and write in a different way:
            if (Input < 10 && Input > 0)
            {
                Console.WriteLine("Bigger");
            }
            /*
             * && - and
             * || - or
             * ! - not
            */
            else
            {
                Console.WriteLine("Less");
            }
            Console.ReadLine();

            if (Input == 1)
            {

            }
            else if (Input == 2)
            {

            }
            else
            {

            }
            we can use also switch, it means the same thing

            switch (Input)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                case 4:
                    break;
                default:
                    break;
            }

            var s = Input == 10 ? "Yes" : "No";     // better to avoid this 
            Console.WriteLine(s);
            Console.ReadLine();



        }
    }
}
