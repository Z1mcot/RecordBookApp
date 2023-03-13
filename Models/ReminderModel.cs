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
    public class ReminderModel : ICrudModel<Reminder>
    {
        FileService<Reminder> _fileService;
        readonly List<Reminder> _remindersList;

        public ReminderModel()
        {
            _fileService = new FileService<Reminder>("../../io");
            _remindersList = _fileService.ReadFromFile("reminders.txt");
        }

        public void DeleteEntry(ListView.SelectedListViewItemCollection selectedEntries)
        {
            throw new NotImplementedException();
        }

        void ICrudModel<Reminder>.CreateEntry(Reminder newEntry)
        {
            throw new NotImplementedException();
        }

        List<Reminder> ICrudModel<Reminder>.FindEntry(string queredParameter, string query)
        {
            throw new NotImplementedException();
        }

        void ICrudModel<Reminder>.UpdateEntry(Reminder oldEntry, Reminder modifiedEntry)
        {
            throw new NotImplementedException();
        }
    }
}
