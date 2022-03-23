using LibraryDAL.Models;
using System.Collections.Generic;

namespace LibraryBLL.Services
{
    public interface IFeedbackService
    {
        void Add(Feedback feedback);
        void Delete(int id);
        IEnumerable<Feedback> GetAll();
        Feedback GetById(int id);
        void Update(Feedback feedback);
    }
}