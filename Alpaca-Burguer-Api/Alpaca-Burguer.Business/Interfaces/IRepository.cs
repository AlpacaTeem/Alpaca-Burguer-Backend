using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Business.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(Guid id);
        Task<bool> Exists(Guid id);
    }
}
