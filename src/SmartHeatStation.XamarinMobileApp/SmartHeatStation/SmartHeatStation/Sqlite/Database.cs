using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SmartHeatStation.Sqlite
{
    public class Database
    {
        static object locker = new object();
        IDatabaseConnection SQLiteDatabase
        {
            get
            {
                return DependencyService.Get<IDatabaseConnection>();
            }
        }

        readonly SQLiteConnection connection;
        readonly string DatabaseName;

        public Database(string databaseName)
        {
            DatabaseName = databaseName;
            connection = SQLiteDatabase.DbConnection(DatabaseName);
        }

        public long GetSize()
        {
            return SQLiteDatabase.GetSize(DatabaseName);
        }

        public void CreateTable<T>()
        {
            lock (locker)
            {
                connection.CreateTable<T>();
            }
        }

        public int SaveItem<T>(T item) where T : Models.BaseSqliteModel
        {
            lock (locker)
            {
                var id = ((Models.BaseSqliteModel)(object)item).ID;
                if (id != 0)
                {
                    connection.Update(item);
                    return id;
                }
                else
                {
                    return connection.Insert(item);
                }
            }
        }

        public int AddItem<T>(T item) where T : Models.BaseSqliteModel
        {
            lock (locker)
            {
                return connection.Insert(item);
            }
        }

        public void ExecuteQuery(string query, object[] args)
        {
            lock (locker)
            {
                connection.Execute(query, args);
            }
        }

        public List<T> Query<T>(string query, params object[] args) where T : new()
        {
            lock (locker)
            {
                return connection.Query<T>(query, args);
            }
        }

        public IEnumerable<T> GetItems<T>() where T : new()
        {
            lock (locker)
            {
                return (from i in connection.Table<T>() select i).ToList();
            }
        }

        public int DeleteItem<T>(int id)
        {
            lock (locker)
            {
                return connection.Delete<T>(id);
            }
        }

        public int DeleteAll<T>()
        {
            lock (locker)
            {
                return connection.DeleteAll<T>();
            }
        }

        public string DatabasePath
        {
            get
            {
                return connection.DatabasePath;
            }
        }

    }
}
