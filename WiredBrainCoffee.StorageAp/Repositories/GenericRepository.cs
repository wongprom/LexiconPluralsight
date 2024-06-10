﻿namespace WiredBrainCoffee.StorageAp.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> items = new();
        public void Add(T item) 
        {
            items.Add(item);
        }

        public void Save()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

}
