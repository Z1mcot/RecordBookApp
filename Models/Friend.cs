using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecordBookApp.Models
{
    public class Friend
    {
        readonly string _fullName;
        readonly DateTime _birthDate;
        readonly string _address;
        readonly string _phoneNumber;
        readonly string _remark;

        public string FullName => _fullName;

        public DateTime BirthDate => _birthDate;

        public string Address => _address;

        public string PhoneNumber => _phoneNumber;

        public string Remark => _remark;

        public Friend(string fullName, DateTime birthDate, string address, string phoneNumber, string remark)
        {
            _fullName = fullName;
            _birthDate = birthDate;
            _address = address;
            _phoneNumber = phoneNumber;
            _remark = remark;
        }

        public Friend(ListViewItem listViewItem) : this (ListViewItemToString(listViewItem)) {}

        public Friend(string rawData)
        {
            string[] splitData = rawData.Split(';');
            
            _fullName = splitData[0];
            if (!DateTime.TryParse(splitData[1], out _birthDate))
                _birthDate = DateTime.Now;
            _address = splitData[2];
            _phoneNumber = splitData[3];
            _remark = splitData[4];
        }

        public Friend() {} // Для работы с FileService

        public override string ToString()
        {
            return string.Join(";", _fullName, _birthDate.ToString(), _address, _phoneNumber, _remark);
        }

        public override bool Equals(object obj)
        {
            try
            {
                var friend = (Friend)obj;
                return friend.FullName == FullName
                    && friend.BirthDate == BirthDate
                    && friend.Address == Address
                    && friend.PhoneNumber == PhoneNumber
                    && friend.Remark == Remark;
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
