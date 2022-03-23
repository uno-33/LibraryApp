using LibraryDAL.Models;
using System.Collections.Generic;

namespace LibraryBLL.Services
{
    public interface IQuestionService
    {
        int Add(Question question);
        void Delete(int id);
        IEnumerable<Question> GetAll();
        Question GetById(int id);
        void Update(Question question);
    }
}