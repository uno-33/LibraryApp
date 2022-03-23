using LibraryDAL.Models;
using LibraryDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryBLL.Services
{
    /// <summary>
    /// Class for working with questionnaire
    /// </summary>
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<Question> _questionRepository;

        public QuestionService(IRepository<Question> repository)
        {
            _questionRepository = repository;
        }

        /// <summary>
        /// Adds new question to DB
        /// </summary>
        /// <param name="question">Question to add</param>
        /// <returns>ID of added question</returns>
        public int Add(Question question)
        {
            return _questionRepository.Add(question).Id;
        }

        /// <summary>
        /// Gets all questions from DB
        /// </summary>
        /// <returns>All questions</returns>
        public IEnumerable<Question> GetAll()
        {
            return _questionRepository.GetAll();
        }

        /// <summary>
        /// Gets one question by id
        /// </summary>
        /// <param name="id">Question id to find</param>
        /// <returns>Found question or null</returns>
        public Question GetById(int id)
        {
            return _questionRepository.GetById(id);
        }

        /// <summary>
        /// Updates question
        /// </summary>
        /// <param name="question">Question to update</param>
        public void Update(Question question)
        {
            _questionRepository.Update(question);
        }

        /// <summary>
        /// Deletes question
        /// </summary>
        /// <param name="id">Question to delete</param>
        public void Delete(int id)
        {
            _questionRepository.Delete(id);
        }
    }
}