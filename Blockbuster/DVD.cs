using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class DVD : Movie   
    {

        public DVD (string Title, Genre Category, int RunTime, List<string> Scenes): base(Title,Category,RunTime,Scenes)
        {

        }

        // ask the user what scene they’d like to watch, print all the available scenes, 
        // and allow the user to select a scene from the list and print it out.
        public override void Play()
        {
            if (Scenes.Count > 0)
            {
                Console.Write($"Which scene do you want to start from? Select 0-{Scenes.Count-1}: ");
                try
                {
                    int selectedScene = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Scene {selectedScene}: {Scenes[selectedScene]}");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Not a valid scene number, please try again");
                    Play();
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Scene number not within range, please try again");
                    Play();
                }
                
            }
            else
            {
                Console.WriteLine("No scenes are avialable to watch");
            }
        }
    }
}
