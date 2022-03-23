using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryDAL.Models
{
    /// <summary>
    /// Question model
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        [Required, StringLength(64, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required, StringLength(64, MinimumLength = 3)]
        public string FavAuthor { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string FavBook { get; set; }
        public bool Hobbit { get; set; }
        public bool HarryPotter { get; set; }
        public bool TheLittlePrince { get; set; }
        public bool DreamOfTheRed { get; set; }
        public bool IsSiteHelpful { get; set; }
    }
}