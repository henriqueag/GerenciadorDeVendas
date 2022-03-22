using GerenciadorEstoque.Data;
using GerenciadorEstoque.Models;
using GerenciadorEstoque.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly AppDataContext _context;

        public ProdutoService(AppDataContext context)
        {
            _context = context;
        }

        public async Task Add(Produto source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            try
            {
                await _context.AddAsync(source);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto source)
        {
            throw new NotImplementedException();
        }
    }
}
