using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.Framework.Business
{
    public interface ICanNotify<TEntity> where TEntity : class
    {
        void Notify(TEntity entity);
    }
}
