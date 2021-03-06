using GerenciadorEstoque.Data;
using GerenciadorEstoque.Models;
using GerenciadorEstoque.Service.Interfaces;
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
            await _context.Produtos.AddAsync(source);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }
    }
}
