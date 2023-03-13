using RecordBookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class FriendListModel
    {
        FileService<Friend> _fileService;
        readonly List<Friend> _friendsList;

        public List<Friend> FriendsList => _friendsList;

        public FriendListModel()
        {
            _fileService = new FileService<Friend>("../../io");
            _friendsList = _fileService.ReadFromFile("friends.txt");
        }

        public void CreateEntry(Friend newFriend)
        {
            _friendsList.Add(newFriend);
            _fileService.WriteToFile(_friendsList, "friends.txt");
        }

        public void UpdateEntry(Friend oldFriend, Friend modifiedFriend)
        {
            RemoveEntryFromList(oldFriend);
            CreateEntry(modifiedFriend);
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

        public void DeleteEntry(ListView.SelectedListViewItemCollection selectedItems)
        {
            foreach (ListViewItem item in selectedItems)
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
