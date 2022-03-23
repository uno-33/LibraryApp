using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryDAL.Models
{
    /// <summary>
    /// Article model
    /// </summary>
    public class Article
    {
        public int Id { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        [Required, StringLength(500, MinimumLength = 3)]
        public string Content { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}