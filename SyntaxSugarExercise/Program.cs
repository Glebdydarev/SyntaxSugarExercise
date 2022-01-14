using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
                  
            //int answer = 4; //expecting typing 
            //string response; //expecting typing

            //if (answer < 9)

             //{
             //response = answer + "is less that nine";

           // }

            //else

             //{
             // response = answer + "geater that or equal to nine";



            //}
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is greater that equal to nine" : $" {answer} is greater that or equa to nine";


            Console.WriteLine(response);







        }    


    }
}
