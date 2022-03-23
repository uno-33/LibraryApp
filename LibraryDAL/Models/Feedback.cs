using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryDAL.Models
{
    /// <summary>
    /// Feedback model
    /// </summary>
    public class Feedback
    {
        public int Id { get; set; }
        [Required, StringLength(64, MinimumLength = 3)]// TODO: fix data annotations
        public string CreatorName { get; set; }
        [Required, StringLength(250, MinimumLength = 3)]
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
    }
}