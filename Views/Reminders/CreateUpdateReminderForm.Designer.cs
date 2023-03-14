namespace RecordBookApp.Views.Reminders
{
    partial class CreateUpdateReminderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EventDescriptionLabel = new System.Windows.Forms.Label();
            this.EventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.CreateUpdateReminderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventDescriptionTextBox
            // 
            this.EventDescriptionTextBox.Location = new System.Drawing.Point(54, 43);
            this.EventDescriptionTextBox.Name = "EventDescriptionTextBox";
            this.EventDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.EventDescriptionTextBox.TabIndex = 3;
            // 
            // EventDescriptionLabel
            // 
            this.EventDescriptionLabel.AutoSize = true;
            this.EventDescriptionLabel.Location = new System.Drawing.Point(51, 27);
            this.EventDescriptionLabel.Name = "EventDescriptionLabel";
            this.EventDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            this.EventDescriptionLabel.TabIndex = 8;
            this.EventDescriptionLabel.Text = "Название события";
            // 
            // EventDatePicker
            // 
            this.EventDatePicker.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\"";
            this.EventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDatePicker.Location = new System.Drawing.Point(54, 95);
            this.EventDatePicker.Name = "EventDatePicker";
            this.EventDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EventDatePicker.TabIndex = 9;
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Location = new System.Drawing.Point(51, 79);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(79, 13);
            this.EventDateLabel.TabIndex = 10;
            this.EventDateLabel.Text = "Дата события";
            // 
            // CreateUpdateReminderBtn
            // 
            this.CreateUpdateReminderBtn.Location = new System.Drawing.Point(54, 145);
            this.CreateUpdateReminderBtn.Name = "CreateUpdateReminderBtn";
            this.CreateUpdateReminderBtn.Size = new System.Drawing.Size(200, 36);
            this.CreateUpdateReminderBtn.TabIndex = 11;
            this.CreateUpdateReminderBtn.Text = "Подтвердить изменения";
            this.CreateUpdateReminderBtn.UseVisualStyleBackColor = true;
            this.CreateUpdateReminderBtn.Click += new System.EventHandler(this.CreateReminderBtn_Click);
            // 
            // CreateUpdateReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 225);
            this.Controls.Add(this.CreateUpdateReminderBtn);
            this.Controls.Add(this.EventDateLabel);
            this.Controls.Add(this.EventDatePicker);
            this.Controls.Add(this.EventDescriptionLabel);
            this.Controls.Add(this.EventDescriptionTextBox);
            this.Name = "CreateUpdateReminderForm";
            this.Text = "Добавить/обновить событие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EventDescriptionTextBox;
        private System.Windows.Forms.Label EventDescriptionLabel;
        private System.Windows.Forms.DateTimePicker EventDatePicker;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Button CreateUpdateReminderBtn;
    }
}