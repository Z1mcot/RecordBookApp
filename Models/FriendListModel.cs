using RecordBookApp.Interfaces;
using RecordBookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace RecordBookApp.Models
{
    public class FriendListModel : ICrudModel<Friend>
    {
        FileService<Friend> _fileService;
        readonly List<Friend> _friendsList;

        public List<Friend> FriendsList => _friendsList;

        public FriendListModel()
        {
            _fileService = new FileService<Friend>("../../io");
            _friendsList = _fileService.ReadFromFile("friends.txt");
        }

        public void CreateEntry(Friend newEntry)
        {
            _friendsList.Add(newEntry);
            _fileService.WriteToFile(_friendsList, "friends.txt");
        }

        public void UpdateEntry(Friend oldEntry, Friend modifiedEntry)
        {
            RemoveEntryFromList(oldEntry);
            CreateEntry(modifiedEntry);
        }


        public List<Friend> FindEntry(string queredParameter, string query)
        {
            switch (queredParameter)
            {
                case "ФИО":
                    return _friendsList.Where(x => x.FullName.Contains(query)).ToList();
                case "Телефон":
                    return new List<Friend> { _friendsList.First(x => x.PhoneNumber.Contains(query)) };
                case "Адрес":
                    return _friendsList.Where(x => x.Address.Contains(query)).ToList();
                default:
                    return _friendsList;
            }
        }

        public void DeleteEntry(SelectedListViewItemCollection selectedEntries)
        {
            foreach (ListViewItem item in selectedEntries)
            { 
                var friendToRemove = new Friend(item);
                RemoveEntryFromList(friendToRemove);
                _fileService.WriteToFile(_friendsList, "friends.txt");
            }
        }

        private void RemoveEntryFromList(Friend entry)
        {
            _friendsList.Remove(entry);
        }
    }
}
