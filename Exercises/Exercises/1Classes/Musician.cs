using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises._1Classes
{
    class Musician
    {
        public Musician(string artist, Guitar guitar)
        {
            Artist = artist;
            Guitar = guitar;

        }

        public void Play()
        {
            Console.WriteLine($"{Artist} plays the {Guitar.GuitarBrand} guitar!");

        }


        public string Artist { get; set; }
        public Guitar Guitar { get; set; } //Guitar is a builtin Class in C#
    }
}
