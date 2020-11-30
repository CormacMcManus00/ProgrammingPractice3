using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;

namespace ProgrammingPractice3
{
    public class Song:IComparable
    {
        //properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }

        //constructors
        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;

        }

        public Song(string title, string artist):this(title,artist,0,Genre.Other)
        {
            Title = title;
            Artist = artist;

            Duration = 0;
            MusicGenre = Genre.Other;


        }

        public Song():this("unknown", "unknown") { }



        //methods

        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }

        public int CompareTo(object other)
        {
            Song that = (Song)other;

            int returnvalue = this.Artist.CompareTo(that.Artist); //Sort by artist

            if (returnvalue == 0)
            {
                returnvalue = this.Title.CompareTo(that.Title); //Sort by title
            }

            return returnvalue;
        }
    }

    public enum Genre { Rock, Pop, Dance, Other}
}