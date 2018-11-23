using System.Linq;
using Visa.API.Context;
using Visa.API.Interface;
using Visa.API.Model;

namespace Visa.API.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        public CardDbContext _cardDbContext { get; private set; }
        public BaseRepository(CardDbContext cardDbContext)
        {
            _cardDbContext = cardDbContext;
        }

        public void Create(T item)
        {
            _cardDbContext.Set<T>().Add(item);
            _cardDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = new T { Id = id };
            _cardDbContext.Set<T>().Attach(entity);
            _cardDbContext.Set<T>().Remove(entity);
            _cardDbContext.SaveChanges();
        }

        public T Read(int id)
        {
            return _cardDbContext.Set<T>().First(e => e.Id == id);
        }

        public void Update(T item)
        {
            _cardDbContext.Set<T>().Update(item);
            _cardDbContext.SaveChanges();
        }
    }
}
