﻿using System.ComponentModel.DataAnnotations;

namespace Mission6_Murdock.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public string Category { get; set; }

        public string Title { get; set; } 

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public string Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }

    }
}
