using RecordBookApp.Views.Diary;
using RecordBookApp.Views.FriendsList;
using RecordBookApp.Views.Reminders;
using System;
using System.Windows.Forms;

namespace RecordBookApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ToFriendsListBtn_Click(object sender, EventArgs e)
        {
            var friendsListForm = new FriendsListForm();
            friendsListForm.Show();
        }

        private void ToDiaryBtn_Click(object sender, EventArgs e)
        {
            var diaryForm = new DiaryForm();
            diaryForm.Show();
        }

        private void ToRemindersBtn_Click(object sender, EventArgs e)
        {
            var remindersForm = new RemindersForm();
            remindersForm.Show();
        }
    }
}
