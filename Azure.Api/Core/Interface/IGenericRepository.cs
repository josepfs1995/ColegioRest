using Azure.Api.Core.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Api.Core.Interface
{
  public interface IGenericRepository<TEntity> where TEntity:class,IAggregateRoot
  {
    Task<IEnumerable<TEntity>> Get();
    Task<TEntity> GetById(Guid id);
    void Add(TEntity model);
    void Update(TEntity model);
    void Delete(Guid id);
  }
}
