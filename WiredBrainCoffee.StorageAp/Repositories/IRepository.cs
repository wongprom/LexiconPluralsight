using WiredBrainCoffee.StorageAp.Entities;

namespace WiredBrainCoffee.StorageAp.Repositories
{
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepository<T> : IReadRepository<T> where T : IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}