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
                //if (string.IsNullOrWhiteSpace(source.CodBarras))
                //{
                //    int ultimoId = await _context.Produtos.MaxAsync(model => model.ProdutoId) + 1;
                //    source.CodBarras = $"{ultimoId:d13}";
                //}
                if (source.Categoria is not null)
                {
                    var categoria = await _context.Categorias.FindAsync(source.Categoria.CategoriaId);
                    source.Categoria = categoria;
                }
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

        public async Task Update(Produto source)
        {
            _context.Update(source);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            var produtos = await _context.Produtos.Include(x => x.Categoria).AsNoTracking().ToListAsync();
            return produtos;
        }

        public async Task<Produto> GetById(int id)
        {           
            var obj = await _context.Produtos.Include(x => x.Categoria).FirstOrDefaultAsync(x => x.ProdutoId == id);
            if (obj is null)
            {
                throw new NullReferenceException("Não foi encontrado nenhum produto com id passado.");
            }
            return obj;
        }

        public async Task Delete(int id)
        {
            try
            {
                _context.Remove(await GetById(id));
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
            catch (Exception)
            {
                throw;
            }

        }
    }
}
