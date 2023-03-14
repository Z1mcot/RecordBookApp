using System.Collections;
using System.Collections.Generic;

namespace RecordBookApp.Interfaces
{
    internal interface ICrudModel<T> // Cud = Create-Read-Update-Delete
    {
        void CreateEntry(T newEntry);
        void UpdateEntry(T oldEntry, T modifiedEntry);
        void DeleteEntries(ICollection selectedEntries);
        List<T> FindEntry(string queredParameter, string query);
    }
}
