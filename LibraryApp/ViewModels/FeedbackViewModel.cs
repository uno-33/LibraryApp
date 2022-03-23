using LibraryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.ViewModels
{
    public class FeedbackViewModel
    {
        public Feedback NewFeedback { get; set; }
        public IEnumerable<Feedback> Feedbacks { get; set; }
    }
}