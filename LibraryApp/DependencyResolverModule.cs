using LibraryBLL.Services;
using LibraryDAL.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApp
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IArticleService>().To<ArticleService>();
            Bind<IFeedbackService>().To<FeedbackService>();
            Bind<IQuestionService>().To<QuestionService>();
            Bind<ITagService>().To<TagService>();
            Unbind<ModelValidatorProvider>();
        }
    }
}