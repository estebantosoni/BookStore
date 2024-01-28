using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T == Category or another entity that needs these methods

        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        //Get that uses a lambda expression is declared as follows
            //Ex. FirstOrDefault(u=>u.Id == id)
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);

        void Add(T entity);
        
        void Remove(T entity);

        //Delete multiple entities in a single column
        void RemoveRange(IEnumerable<T> entity);

        //Update could be more complex than the other methods, so it will be separated from the rest
        //void Update(T entity);
    }

}
