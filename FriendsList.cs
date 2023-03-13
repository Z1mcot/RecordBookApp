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
using System.Windows.Forms.VisualStyles;

namespace RecordBookApp
{
    public partial class FriendsList : Form
    {
        FriendListModel _model;
        public FriendsList()
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
                string[] row = { item.FullName, item.BirthDate.Date.ToString(), item.Address, item.PhoneNumber, item.Remark };
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
                    _model.DeleteEntry(selectedItems);
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
