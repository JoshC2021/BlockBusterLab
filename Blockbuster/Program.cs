using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GC Blockbuster");
            Blockbuster b = new Blockbuster();
            Movie movie = b.CheckOut();
            Console.Write("Do you want to watch the movie?(Y/N): ");
            if(ConfirmSelection(Console.ReadLine(), "Y", "N"))
            {
                Console.Write("Do you want to watch from start to finish or a specific scene?(Start/Scene): ");
                if(ConfirmSelection(Console.ReadLine(), "START", "SCENE"))
                {
                    Console.WriteLine("\nNow playing {0},", movie.Title);
                    movie.PlayWholeMovie();
                }
                else
                {
                    bool isWatching = true;
                    Console.WriteLine("\nNow playing {0},", movie.Title);
                    while (isWatching)
                    {
                        movie.Play();
                        Console.Write("Do you want to watch another scene (Y/N): ");
                        isWatching = ConfirmSelection(Console.ReadLine(), "Y", "N");

                    }
                }
                
            }

            Console.WriteLine("\nFin");
        }

        // Confirms user wants to do a selection
        public static bool ConfirmSelection(string s,string a1,string a2)
        {
            if (s.ToUpper().Trim() == a1)
            {
                return true;
            }
            else if (s.ToUpper().Trim() == a2)
            {
                return false;
            }
            else
            {
                Console.Write($"\nInvalid response, Please Enter {a1} or {a2}: ");
                ConfirmSelection(Console.ReadLine(),a1,a2);
            }
            return true;
        }
    }
}
