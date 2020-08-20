using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CRUD_menu
{
    class Video
    {
        private static int _globalId;
        public int Id { get; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Storyline { get; set; }
        public string Genre { get; set; }

        public Video(string title, DateTime releaseDate, string storyline , string genre)
        {
            _globalId++;
            Id = _globalId;
            Title = title;
            ReleaseDate = releaseDate;
            Storyline = storyline;
            Genre = genre;

        }
    }
}
