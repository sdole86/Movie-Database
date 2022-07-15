using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Project
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int TomatoScore { get; set; }
        public decimal BoxOffice { get; set; }
    }
}

