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
    public class RemindersModel : ICrudModel<Reminder>
    {
        readonly FileService<Reminder> _fileService;
        readonly List<Reminder> _remindersList;
        readonly string _fileName = "reminders.txt";
        
        int _upcomingEventsCount;

        public List<Reminder> RemindersList => _remindersList;

        public int UpcomingEventsCount => _upcomingEventsCount;

        public RemindersModel()
        {
            _fileService = new FileService<Reminder>();
            _remindersList = _fileService.ReadFromFile(_fileName);
            CalculateUpcomingEventsCount();
        }

        public void CreateEntry(Reminder newEntry)
        {
            _remindersList.Add(newEntry);
            _fileService.WriteToFile(_remindersList, _fileName);
        }

        public void DeleteEntries(ICollection selectedEntries)
        {
            foreach (ListViewItem item in selectedEntries)
            {
                var entryToRemove = new Reminder(item);
                _remindersList.Remove(entryToRemove);
                _fileService.WriteToFile(_remindersList, _fileName);
            }
        }

        public List<Reminder> FindEntry(string queredParameter, string query)
        {
            switch (queredParameter)
            {
                case "Дата":
                    return _remindersList.Where(x => x.EventDate.Date == DateTime.Parse(query, CultureInfo.GetCultureInfo("ru-RU"))).ToList();
                case "Событие":
                    return _remindersList.Where(x => x.Description.Contains(query)).ToList();
                default:
                    return _remindersList;
            }
        }

        public void UpdateEntry(Reminder oldEntry, Reminder modifiedEntry)
        {
            int entryIndex = _remindersList.IndexOf(oldEntry);
            _remindersList[entryIndex] = modifiedEntry;
            _fileService.WriteToFile(_remindersList, _fileName);
        }

        private void CalculateUpcomingEventsCount()
        {
            foreach (var eventEntry in RemindersList)
            {
                var dateDiff = eventEntry.EventDate.Date - DateTime.Now.Date;
                if (dateDiff > TimeSpan.Zero && dateDiff < TimeSpan.FromDays(5))
                {
                    _upcomingEventsCount++;
                }
            }
        }
    }
}
