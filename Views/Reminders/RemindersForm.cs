using RecordBookApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RecordBookApp.Views.Reminders
{
    public partial class RemindersForm : Form
    {
        readonly RemindersModel _model;
        public RemindersForm()
        {
            InitializeComponent();
            
            _model = new RemindersModel();

            UpdateForm();
        }

        public void UpdateForm()
        {
            List<Reminder> remindersList = _model.RemindersList;
            LoadListView(remindersList);
        }

        private void LoadListView(List<Reminder> listToShow)
        {
            RemindersListView.Items.Clear();
            var orderedList = listToShow.OrderBy(x => x.EventDate);

            foreach(var item in listToShow)
            {
                string[] row = { item.EventDate.ToString(CultureInfo.GetCultureInfo("ru-RU")), item.Description };
                var listItem = new ListViewItem(row);
                RemindersListView.Items.Add(listItem);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RemindersListView.SelectedItems != null)
            {
                var responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = RemindersListView.SelectedItems;
                    _model.DeleteEntries(selectedItems);
                }

                var updatedList = _model.RemindersList;
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
            var createForm = new CreateUpdateReminderForm(this, _model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = RemindersListView.SelectedItems[0];

            var createForm = new CreateUpdateReminderForm(this, _model, selectedItem);
            createForm.Show();
        }

        private void ShowUpcomingEventsCount()
        {
            MessageBox.Show($"Количество ближайших событий: {_model.UpcomingEventsCount}", "Предупреждение", MessageBoxButtons.OK);
        }

        private void RemindersForm_Load(object sender, EventArgs e)
        {
            if (_model.UpcomingEventsCount != 0) ShowUpcomingEventsCount();
        }
    }
}
