using RecordBookApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class Reminder
    {
        readonly DateTime _eventDate;
        readonly string _description;

        public Reminder()
        {
        }

        public Reminder(DateTime eventDate, string description)
        {
            _eventDate = eventDate;
            _description = description;
        }

        public DateTime EventDate => _eventDate;

        public string Description => _description;

        public Reminder(ListViewItem listViewItem) : this(ListViewItemToString(listViewItem)) { }

        public Reminder(string rawData)
        {
            string[] splitData = rawData.Split(';');

            if (!DateTimeParser.TryParse(splitData[0], out _eventDate))
                _eventDate = DateTime.Now;
            _description = splitData[1];

        }

        public override string ToString()
        {
            return string.Join(";", EventDate.ToString(), Description);
        }

        public override bool Equals(object obj)
        {
            try
            {
                var reminder = (Reminder)obj;
                return reminder.EventDate == EventDate
                    && reminder.Description == Description;
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private static string ListViewItemToString(ListViewItem item)
        {
            List<string> unpackedListViewItem = new List<string>();
            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
            {
                unpackedListViewItem.Add(subItem.Text);
            }

            return string.Join(";", unpackedListViewItem);
        }
    }
}
