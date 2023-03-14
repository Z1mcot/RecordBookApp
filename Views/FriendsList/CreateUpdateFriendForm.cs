using RecordBookApp.Models;
using System;
using System.Windows.Forms;

namespace RecordBookApp.Views.FriendsList
{
    public partial class CreateUpdateFriendForm : Form
    {
        readonly FriendListModel _model;
        readonly FriendsListForm _parentForm;
        readonly Friend _oldFriend;
        public CreateUpdateFriendForm(FriendsListForm parentForm, FriendListModel model, ListViewItem oldEntry = default)
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
