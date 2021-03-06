using System;
using System.Numerics; // BigInteger
using System.Collections.Generic;

namespace P4
{
    class Program
    {
        public static string P4(string[] args)
        {
            /*
            * useful help for RSA encrypt/decrypt: https://www.di-mgt.com.au/rsa_alg.html
            * help with extended euclidean algorithm: https://en.wikipedia.org/wiki/Extended_Euclidean_algorithm
            * 
            */

            Console.WriteLine("just printing the input");
            foreach(var item in args)
            {
                Console.WriteLine(item); //DELETE, just a placeholder
            }

            // Some other helpful links: https://gist.github.com/GiveThanksAlways/00a5c4e911795992268b0c998e2ec487

            // dotnet run 254 1223 251 1339 66536047120374145538916787981868004206438539248910734713495276883724693574434582104900978079701174539167102706725422582788481727619546235440508214694579  1756026041
            string P4_answer = "Edward Snowden";
            return P4_answer;
        }

        static void Main(string[] args)
        {
            // args is the array that contains the command line inputs
            P4(args); // This will run your project code. The autograder will grade the return value of the P1_2 function
        }
    }
}
