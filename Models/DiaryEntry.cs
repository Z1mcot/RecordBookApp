using RecordBookApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class DiaryEntry
    {
        readonly DateTime _entryDate;
        readonly string _content;

        public DateTime EntryDate => _entryDate;

        public string Content => _content;

        public DiaryEntry()
        {
        }

        public DiaryEntry(DateTime entryDate, string content)
        {
            _entryDate = entryDate;
            _content = content;
        }

        public DiaryEntry(DataGridViewRow listViewItem) : this(DataGridItemToString(listViewItem)) { }

        public DiaryEntry(string rawData)
        {
            string[] splitData = rawData.Split(';');
            
            if (!DateTimeParser.TryParse(splitData[0], out _entryDate))
                  _entryDate = DateTime.Now;
            _content = splitData[1];

        }

        public override string ToString()
        {
            return string.Join(";", EntryDate.ToString(), Content);
        }

        public override bool Equals(object obj)
        {
            try
            {
                var diaryEntry = (DiaryEntry)obj;
                return diaryEntry.EntryDate.Date == EntryDate.Date
                    && diaryEntry.Content == Content;
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

        private static string DataGridItemToString(DataGridViewRow item)
        {
            List<string> unpackedListViewItem = new List<string>();
            foreach (DataGridViewCell subItem in item.Cells)
            {
                unpackedListViewItem.Add((string)subItem.Value);
            }

            return string.Join(";", unpackedListViewItem);
        }
    }
}
