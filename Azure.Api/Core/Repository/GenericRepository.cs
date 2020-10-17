using Azure.Api.Core.Aggregate;
using Azure.Api.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Repository
{
  public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity:class,IAggregateRoot
  {
    private ColegioContext _context;
    private DbSet<TEntity> DbSet; 
    public GenericRepository(ColegioContext context)
    {
      _context = context;
      DbSet = context.Set<TEntity>();
    }
    public void Add(TEntity model)
    {
      DbSet.Add(model);
      _context.SaveChanges();
    }

    public void Delete(Guid id)
    {
      var entity = DbSet.Find(id);
      DbSet.Remove(entity);
      _context.SaveChanges();
    }

    public virtual async Task<IEnumerable<TEntity>> Get()
    {
      return await DbSet.ToListAsync();
    }

    public async Task<TEntity> GetById(Guid id)
    {
      return await DbSet.FindAsync(id);
    }

    public void Update(TEntity model)
    {
      DbSet.Update(model);
      _context.SaveChanges();
    }
  }
}
