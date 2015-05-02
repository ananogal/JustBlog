using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustBlog.Infrastructure
{
    public interface IJustBlogDb : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    }
}