using RecordBookApp.Interfaces;
using RecordBookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class DiaryModel : ICrudModel<DiaryEntry>
    {
        FileService<DiaryEntry> _fileService;
        readonly List<DiaryEntry> _diaryEntriesList;

        public DiaryModel()
        {
            _fileService = new FileService<DiaryEntry>("../../io");
            _diaryEntriesList = _fileService.ReadFromFile("diary.txt");
        }

        public void CreateEntry(DiaryEntry newEntry)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(ListView.SelectedListViewItemCollection selectedEntries)
        {
            throw new NotImplementedException();
        }

        public List<DiaryEntry> FindEntry(string queredParameter, string query)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(DiaryEntry oldEntry, DiaryEntry modifiedEntry)
        {
            throw new NotImplementedException();
        }
    }
}
