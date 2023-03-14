using RecordBookApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RecordBookApp.Views.Diary
{
    public partial class DiaryForm : Form
    {
        readonly DiaryModel _model;
        public DiaryForm()
        {
            InitializeComponent();
            
            _model = new DiaryModel();
            UpdateForm();
        }

        public void UpdateForm()
        {
            List<DiaryEntry> diary = _model.DiaryEntriesList;
            LoadListView(diary);
        }

        private void LoadListView(List<DiaryEntry> listToShow)
        {
            DiaryDataGrid.Rows.Clear();
            var orderedList = listToShow.OrderBy(x => x.EntryDate);

            foreach(var item in listToShow)
            {
                string[] row = { item.EntryDate.Date.ToString(CultureInfo.GetCultureInfo("ru-RU")), item.Content };
                
                DiaryDataGrid.Rows.Add(row);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DiaryDataGrid.Rows != null)
            {
                var responce = MessageBox.Show("Вы правда хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (responce == DialogResult.Yes)
                {
                    var selectedItems = DiaryDataGrid.SelectedRows;
                    _model.DeleteEntries(selectedItems);
                }

                var updatedList = _model.DiaryEntriesList;
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
            var createForm = new CreateUpdateDiaryEntryForm(this, _model);
            createForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = DiaryDataGrid.SelectedRows[0];

            var createForm = new CreateUpdateDiaryEntryForm(this, _model, selectedItem);
            createForm.Show();
        }
    }
}
