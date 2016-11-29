using SQLite.Net.Attributes;
using System;

namespace xamarin_msp_3.Model
{
    public class noteModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        public string Date { get; set; }

        public noteModel()
        {
        }

    }
}
