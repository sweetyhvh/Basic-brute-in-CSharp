using System;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThere's a simple Brute-force to see how Brute-force works :D");
            Console.WriteLine("Enjoy learning");
            Console.WriteLine("-----------------------------------------------------");

            //Asking for the password
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            string attempts = "";

            //Counters
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int cracks = 0;

            //Let's make an array with all letters a - z
            string[] array = new string[27];
            array[0] = ""; //First Empty
            array[1] = "a";
            array[2] = "b";
            array[3] = "c";
            array[4] = "d";
            array[5] = "e";
            array[6] = "f";
            array[7] = "g";
            array[8] = "h";
            array[9] = "i";
            array[10] = "j";
            array[11] = "k";
            array[12] = "l";
            array[13] = "m";
            array[14] = "n";
            array[15] = "o";
            array[16] = "p";
            array[17] = "q";
            array[18] = "r";
            array[19] = "s";
            array[20] = "t";
            array[21] = "u";
            array[22] = "v";
            array[23] = "w";
            array[24] = "x";
            array[25] = "y";
            array[26] = "z";

            //Happy Cracking >:D
            while (!attempts.Equals(password))
            {
                if (first == array.Length)
                {
                    second++;
                    first = 0;
                }
                if (second == array.Length)
                {
                    third++;
                    second = 0;
                }
                if (third == array.Length)
                {
                    fourth++;
                    third = 0;
                }
                if (fourth == array.Length)
                {
                    break; //End >:D
                }

                attempts = array[fourth] + array[third] + array[second] + array[first];

                Console.WriteLine(attempts);
                first++;
                cracks++;
            }

            Console.WriteLine("\n[*] Attempts to crack " + cracks);
            Console.WriteLine("[+] Password found " + attempts);
            Console.WriteLine("[+] Made by sweety#3848");
        }
    }
}
