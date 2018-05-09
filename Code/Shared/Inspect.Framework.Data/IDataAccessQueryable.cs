using System;
using System.Linq;
using System.Linq.Expressions;

namespace Inspect.Framework.Data
{
    public interface IDataAccessQueryable<TObject>
    {
        IQueryable<TObject> Include(string path);

        IQueryable<TObject> Include<TProperty>(Expression<Func<TObject, TProperty>> path);
    }
}