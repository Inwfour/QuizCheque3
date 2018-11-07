using System;
using System.Linq;

namespace QuizCheque3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            int[] number = new int[4];
            string[] check = new string[] { "#1 $5", "#2 $10", "#3 $15" };
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter amount #" + i + 1);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(check[0]);
            Console.WriteLine(check[1]);
            Console.WriteLine(check[2]);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("For " + number[i]);
                if (number[i] % 5 == 0 && number[i] != 0)
                {
                        if (number[i] >= 15)
                        {
                            Console.WriteLine(" + " + check[2]);
                            number[i] -= 15;

                        }
                    
                    if (number[i] >= 10 && number[i] < 15)
                    {
                        Console.WriteLine(" + " + check[1]);
                        number[i] -= 10;

                    }

                    if (number[i] >= 5 && number[i] < 10)
                    {
                        Console.WriteLine(" + " + check[0]);
                        number[i] -= 5;

                    }



                }
            }


            // for (int i = 0; i < 4; i++)
            // {
            //     if (number[i] % 5 == 0)
            //     {
            //         for (int j = 5; j <= number[i];j++)
            //         {
            //             if(number[i] % j == 0 && j % 5 == 0){
            //                 Console.WriteLine("For " + number[i]);
            //                 Console.WriteLine(" + #" + j);

            //             }else{

            //             }

            //         }
            //     }else{
            //         // Console.WriteLine("no");
            //     }
            // }

        }
    }
}
