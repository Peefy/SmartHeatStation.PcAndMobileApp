using System;
using System.IO;

using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SmartHeatStation.Droid.Sqlite.DatabaseConnectionDroid))]
namespace SmartHeatStation.Droid.Sqlite
{
    public class DatabaseConnectionDroid : SmartHeatStation.Sqlite.IDatabaseConnection
    {
        string GetPath(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName))
            {
                throw new ArgumentException("Invalid database name", nameof(databaseName));
            }
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, databaseName);
            return path;
        }

        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            return new SQLiteConnection(GetPath(dbName));
        }

        public SQLiteConnection DbConnection(string dbName)
        {
            return new SQLiteConnection(GetPath(dbName));
        }

        public long GetSize(string databaseName)
        {
            var fileInfo = new FileInfo(GetPath(databaseName));
            return fileInfo != null ? fileInfo.Length : 0;
        }
    }
}