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
    public class CategoriaService : ICategoriaService
    {
        private readonly AppDataContext _context;

        public CategoriaService(AppDataContext context)
        {
            _context = context;
        }

        public async Task Add(Categoria source)
        {
            await _context.Categorias.AddAsync(source);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _context.Categorias.AsNoTracking().ToListAsync();
        }
    }
}
