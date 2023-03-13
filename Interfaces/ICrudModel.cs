using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.ListView;

namespace RecordBookApp.Interfaces
{
    internal interface ICrudModel<T> // Cud = Create-Read-Update-Delete
    {
        void CreateEntry(T newEntry);
        void UpdateEntry(T oldEntry, T modifiedEntry);
        void DeleteEntry(SelectedListViewItemCollection selectedEntries);
        List<T> FindEntry(string queredParameter, string query);
    }
}
