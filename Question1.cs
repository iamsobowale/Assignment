using System;
namespace BayoChallenge
{
    public class Question1
    {
       public static void  Anwser()
        {
            int[] arr = new int[]{3,0,2,11}; 
            bool ItExist=false;
            for (int i = 0; i < arr.Length; i++)
            {
               for (int j = 0; j <arr.Length; j++)
               {
                   if (arr[i]== 2*arr[j])
                   {
                    //   return true;
                     ItExist=true;;
                   }
               }
            }
            Console.WriteLine(ItExist);
            // return false;
        }
    }
}