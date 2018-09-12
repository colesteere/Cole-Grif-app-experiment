using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Chores> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}