using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DoggoAdoption
{
    public class Database
    {
        
         public readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<DogInfo>();
        }

        public Task<List<DogInfo>> GetDogAsync()
        {
            return _database.Table<DogInfo>().ToListAsync();
        }

        public Task<int> SaveDogAsync(DogInfo dog)
        {
            return _database.InsertAsync(dog);
        }
    }
}
