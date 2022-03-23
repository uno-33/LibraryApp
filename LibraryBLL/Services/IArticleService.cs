using LibraryDAL.Models;
using System.Collections.Generic;

namespace LibraryBLL.Services
{
    public interface IArticleService
    {
        void Add(Article article);
        void Delete(int id);
        IEnumerable<Article> GetAll();
        Article GetById(int id);
        void Update(Article article);
    }
}