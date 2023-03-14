using RecordBookApp.Interfaces;
using RecordBookApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class DiaryModel : ICrudModel<DiaryEntry>
    {
        readonly FileService<DiaryEntry> _fileService;
        readonly List<DiaryEntry> _diaryEntriesList;
        readonly string _fileName = "diary.txt";

        public List<DiaryEntry> DiaryEntriesList => _diaryEntriesList;

        public DiaryModel()
        {
            _fileService = new FileService<DiaryEntry>();
            _diaryEntriesList = _fileService.ReadFromFile(_fileName);
        }

        public void CreateEntry(DiaryEntry newEntry)
        {
            _diaryEntriesList.Add(newEntry);
            _fileService.WriteToFile(_diaryEntriesList, _fileName);
        }

        public void DeleteEntries(ICollection selectedEntries)
        {
            foreach (DataGridViewRow item in selectedEntries)
            {
                var entryToRemove = new DiaryEntry(item);
                _diaryEntriesList.Remove(entryToRemove);
                _fileService.WriteToFile(_diaryEntriesList, _fileName);
            }
        }

        public List<DiaryEntry> FindEntry(string queredParameter, string query)
        {
                switch (queredParameter)
                {
                    case "Дата":
                        return _diaryEntriesList.Where(x => x.EntryDate.Date == DateTime.Parse(query, CultureInfo.GetCultureInfo("ru-RU"))).ToList();
                    case "Запись":
                        return _diaryEntriesList.Where(x => x.Content.Contains(query)).ToList();
                    default:
                        return _diaryEntriesList;
                }
        }

        public void UpdateEntry(DiaryEntry oldEntry, DiaryEntry modifiedEntry)
        {
            int entryIndex = _diaryEntriesList.IndexOf(oldEntry);
            _diaryEntriesList[entryIndex] = modifiedEntry;
            _fileService.WriteToFile(_diaryEntriesList, _fileName);
        }
    }
}
