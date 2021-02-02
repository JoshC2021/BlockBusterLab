using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public enum Genre
    {
        Drama,
        Action,
        Horror,
        Romance,
        Comedy
    }

    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        

        public Movie(string Title, Genre Category, int RunTime,List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        // prints all the porperties of the class to the console save for the scenes
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Title}\nCategory: {Category}\nRuneTime: {RunTime}");
        }

        // prints all scenes adn their index
        public void PrintScenea()
        {
            for(int i =0; i< Scenes.Count;i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        public abstract void Play();

        public virtual void PlayWholeMovie()
        {
            Console.WriteLine("\nThis production brought to you by Tommy");
            foreach (string scene in Scenes)
            { 
                Console.WriteLine(scene);
            }
        }
    }
}
