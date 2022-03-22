using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Service.Interface
{
    public interface IServiceGeneric<TSource> where TSource : class
    {
        Task Add(TSource source);
        Task Update(TSource source);
        Task Delete(int id);
        Task<TSource> GetById(int id);
        Task<IEnumerable<TSource>> GetAll();
    }
}
