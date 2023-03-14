using RecordBookApp.Models;
using System;
using System.Windows.Forms;

namespace RecordBookApp.Views.Diary
{
    public partial class CreateUpdateDiaryEntryForm : Form
    {
        readonly DiaryModel _model;
        readonly DiaryForm _parentForm;
        readonly DiaryEntry _oldEntry;
        public CreateUpdateDiaryEntryForm(DiaryForm parentForm, DiaryModel model, DataGridViewRow oldEntry = default)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _model = model;

            if (oldEntry != default)
            {
                _oldEntry = new DiaryEntry(oldEntry);
                EntryDatePicker.Value = _oldEntry.EntryDate;
                ContentTextBox.Text = _oldEntry.Content;
            }
        }

        private void CreateDiaryEntryBtn_Click(object sender, EventArgs e)
        {
            DiaryEntry newEntry = new DiaryEntry(
                entryDate: EntryDatePicker.Value,
                content: ContentTextBox.Text
                );

            if (_oldEntry == default)
                _model.CreateEntry(newEntry);
            else
            {
                _model.UpdateEntry(_oldEntry, newEntry);
            }
            _parentForm.UpdateForm();
            Close();
        }
    }
}
