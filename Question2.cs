using System;
namespace BayoChallenge
{
    public class Question2
    {
        public static void Anwser()
        {
            int num=7;
            int Divisor=num/2;
            int count =0;
            bool IsDivisible=false;
            for (int i = 1; i <=Divisor; i++)
            {
                if (num%i==0)
                {
                    count+=i;
                }
            }
             if (num==count)
                {
                   IsDivisible=true; 
                }
            Console.WriteLine(IsDivisible);
            
        }
    }
}