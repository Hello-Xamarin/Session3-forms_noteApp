using System;
using System.IO;
using Xamarin.Forms;
using xamarin_msp_3.Droid;
using xamarin_msp_3.Interface;

[assembly: Dependency(typeof(SQLiteAction))]
namespace xamarin_msp_3.Droid
{
    public class SQLiteAction : i_SQLite
    {
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var filename = "Notes.db";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}