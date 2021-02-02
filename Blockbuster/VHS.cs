using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title,Category,RunTime,Scenes)
        {
            CurrentTime = 0;
        }

        //  plays the scene at the current time and then increments CurrentTime
        public override void  Play()
        {
            
            if(CurrentTime < Scenes.Count)
            {
                Console.WriteLine($"Scene {CurrentTime}: {Scenes[CurrentTime]}");
                CurrentTime++;
            }
            if(CurrentTime >= Scenes.Count)
            {
                Console.WriteLine("Movie has now ended, Now rewinding to the beginning");
                Rewind();
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void PlayWholeMovie()
        {
            Rewind();
            base.PlayWholeMovie();
        }
    }
}
