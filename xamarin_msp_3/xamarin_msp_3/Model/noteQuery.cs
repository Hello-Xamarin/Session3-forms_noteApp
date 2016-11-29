using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite.Net;
using xamarin_msp_3.Interface;

namespace xamarin_msp_3.Model
{
    public class noteQuery
    {
        SQLiteConnection _sqlconnection;

        public noteQuery()
        {
            _sqlconnection = DependencyService.Get<i_SQLite>().GetConnection();
            _sqlconnection.CreateTable<noteModel>();
        }

        //Insert Note
        public int InsertDetails(noteModel notesDB)
        {
            return _sqlconnection.Insert(notesDB);
        }

        //Update Note
        public int UpdateDetails(noteModel noteDB)
        {
            return _sqlconnection.Update(noteDB);
        }

        //Delete Note
        public int DeleteNote(int id)
        {
            return _sqlconnection.Delete<noteModel>(id);
        }

        //Get all Notes
        public IEnumerable<noteModel> GetAllNotes()
        {
            return (from i in _sqlconnection.Table<noteModel>() select i).ToList();
        }


        //Dispose
        public void Dispose()
        {
            _sqlconnection.Dispose();
        }



    }
}
