using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamarin_msp_3.Interface
{
    public interface i_SQLite
    {
        SQLiteConnection GetConnection();
    }
}
