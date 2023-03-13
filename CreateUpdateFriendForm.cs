using RecordBookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordBookApp
{
    public partial class CreateUpdateFriendForm : Form
    {
        FriendListModel _model;
        FriendsList _parentForm;
        Friend _oldFriend;
        public CreateUpdateFriendForm(FriendsList parentForm, FriendListModel model, ListViewItem oldEntry = default)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _model = model;

            if (oldEntry != default)
            {
                _oldFriend = new Friend(oldEntry);
                FullNameTextBox.Text = _oldFriend.FullName;
                BirthDatePicker.Value = _oldFriend.BirthDate;
                AddressTextBox.Text = _oldFriend.Address;
                PhoneTextBox.Text = _oldFriend.PhoneNumber;
                RemarkTextBox.Text = _oldFriend.Remark;
            }
        }

        private void CreateFriendBtn_Click(object sender, EventArgs e)
        {
            Friend friend = new Friend(fullName: FullNameTextBox.Text,
                                       birthDate: BirthDatePicker.Value,
                                       address: AddressTextBox.Text,
                                       phoneNumber: PhoneTextBox.Text,
                                       remark: RemarkTextBox.Text);
            if (_oldFriend == default)
                _model.CreateEntry(friend);
            else
            {
                _model.UpdateEntry(_oldFriend, friend);
            }
            _parentForm.UpdateForm();
            Close();
        }
    }
}
