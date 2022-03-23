using LibraryDAL.Models;
using LibraryDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryBLL.Services
{
    /// <summary>
    /// Class for working with articles
    /// </summary>
    public class ArticleService : IArticleService
    {
        private readonly IRepository<Article> _articleRepository;

        public ArticleService(IRepository<Article> repository)
        {
            _articleRepository = repository;
        }

        /// <summary>
        /// Adds new article to DB
        /// </summary>
        /// <param name="article">Article to add</param>
        /// <returns>ID of added article</returns>
        public void Add(Article article)
        {
            _articleRepository.Add(article);
        }

        /// <summary>
        /// Gets all articles from DB
        /// </summary>
        /// <returns>All articles</returns>
        public IEnumerable<Article> GetAll()
        {
            return _articleRepository.GetAll();
        }

        /// <summary>
        /// Gets one article by id
        /// </summary>
        /// <param name="id">Article id to find</param>
        /// <returns>Found article or null</returns>
        public Article GetById(int id)
        {
            return _articleRepository.GetById(id);
        }

        /// <summary>
        /// Updates article
        /// </summary>
        /// <param name="article">Article to update</param>
        public void Update(Article article)
        {
            _articleRepository.Update(article);
        }
        /// <summary>
        /// Deletes article
        /// </summary>
        /// <param name="id">Article to delete</param>
        public void Delete(int id)
        {
            _articleRepository.Delete(id);
        }
    }
}