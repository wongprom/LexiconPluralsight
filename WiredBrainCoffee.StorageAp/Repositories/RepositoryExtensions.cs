namespace WiredBrainCoffee.StorageAp.Repositories
{
    public static  class RepositoryExtensions
    {
        public static void AddBatch<T>(this IWriteRepository<T> repository, T[] items)
        {
            foreach (var organizationItem in items)
            {
                repository.Add(organizationItem);
            }
            repository.Save();
        }
    }
}
