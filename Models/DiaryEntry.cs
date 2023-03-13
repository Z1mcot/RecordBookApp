using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        public DiaryEntry(ListViewItem listViewItem) : this(ListViewItemToString(listViewItem)) { }

        public DiaryEntry(string rawData)
        {
            string[] splitData = rawData.Split(';');

            if (!DateTime.TryParse(splitData[0], out _entryDate))
                _entryDate = DateTime.Now;
            _content = splitData[1];

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
