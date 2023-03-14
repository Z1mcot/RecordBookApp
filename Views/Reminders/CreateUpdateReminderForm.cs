using RecordBookApp.Models;
using System;
using System.Windows.Forms;

namespace RecordBookApp.Views.Reminders
{
    public partial class CreateUpdateReminderForm : Form
    {
        readonly RemindersModel _model;
        readonly RemindersForm _parentForm;
        readonly Reminder _oldEntry;
        public CreateUpdateReminderForm(RemindersForm parentForm, RemindersModel model, ListViewItem oldEntry = default)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _model = model;

            if (oldEntry != default)
            {
                _oldEntry = new Reminder(oldEntry);
                EventDatePicker.Value = _oldEntry.EventDate;
                EventDescriptionTextBox.Text = _oldEntry.Description;
            }
        }

        private void CreateReminderBtn_Click(object sender, EventArgs e)
        {
            Reminder newEntry = new Reminder(
                eventDate: EventDatePicker.Value,
                description: EventDescriptionTextBox.Text
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
