using WiredBrainCoffee.StorageAp.Entities;

namespace WiredBrainCoffee.StorageAp.Repositories
{
    public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    {
        public void Remove(T item)
        {
            items.Remove(item);
        }
    }

}
