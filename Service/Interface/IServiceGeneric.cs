using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Service.Interface
{
    public interface IServiceGeneric<TSource> where TSource : class
    {
        Task Add(TSource source);
        void Update(TSource source);
        void Delete(int id);
        void GetById(int id);
        IEnumerable<TSource> GetAll();
    }
}
