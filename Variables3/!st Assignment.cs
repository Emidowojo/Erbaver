using System;

namespace Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string lotteryNo1 = "";
             string lotteryNo2 = "";
             string lotteryNo3 ="";
            string result = "";

            Console.Write("Enter Lottery No1: ");
            lotteryNo1 = Console.ReadLine();


           Console.Write("Enter Lottery No2: " );
            lotteryNo2 = Console.ReadLine();

            Console.Write("Enter Lottery No3: ");
             lotteryNo3 =Console.ReadLine();


        

           result = lotteryNo1 + lotteryNo2 + lotteryNo3;
           Console.WriteLine("The answer is: " + result);
          
            
        }
    }
}
