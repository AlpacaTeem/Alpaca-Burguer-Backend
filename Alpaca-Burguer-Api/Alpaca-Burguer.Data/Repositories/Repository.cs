using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using Alpaca_Burguer.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected AlpacaBurguerDbContext _context;
        public Repository(AlpacaBurguerDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<T> Add(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<T> Delete(Guid id)
        {
            var product = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> Exists(Guid id)
        {
            return await _context.Set<T>().AnyAsync(e => e.Id == id);
        }

        public async Task<T> Get(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
