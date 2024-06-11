using WiredBrainCoffee.StorageAp.Entities;

namespace WiredBrainCoffee.StorageAp.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}