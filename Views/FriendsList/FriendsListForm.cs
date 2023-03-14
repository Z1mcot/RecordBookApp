using RecordBookApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RecordBookApp.Views.FriendsList
{
    public partial class FriendsListForm : Form
    {
        readonly FriendListModel _model;
        public FriendsListForm()
        {
            InitializeComponent();
            
            _model = new FriendListModel();
            UpdateForm();
        }

        public void UpdateForm()
        {
            List<Friend> friendList = _model.FriendsList;
            LoadListView(friendList);
        }

        private void LoadListView(List<Friend> listToShow)
        {
            FriendsListView.Items.Clear();
            var orderedList = listToShow.OrderBy(x => x.FullName);

            foreach(var item in listToShow)
            {
                string[] row = { item.FullName, item.BirthDate.Date.ToString("d", CultureInfo.GetCultureInfo("ru-RU")), item.Address, item.PhoneNumber, item.Remark };
                var listItem = new ListViewItem(row);
                FriendsListView.Items.Add(listItem);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (FriendsListView.SelectedItems != null)
            {
                var responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = FriendsListView.SelectedItems;
                    _model.DeleteEntries(selectedItems);
                }

                var updatedList = _model.FriendsList;
                LoadListView(updatedList);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            var queredParameter = QueredParameterCmbBx.Text;
            var query = SearchBox.Text;

            var queredList = _model.FindEntry(queredParameter, query);
            LoadListView(queredList);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var createForm = new CreateUpdateFriendForm(this, _model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = FriendsListView.SelectedItems[0];

            var createForm = new CreateUpdateFriendForm(this, _model, selectedItem);
            createForm.Show();
        }
    }
}
