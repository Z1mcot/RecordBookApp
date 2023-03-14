namespace RecordBookApp.Views.Diary
{
    partial class CreateUpdateDiaryEntryForm
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
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.EntryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EntryDateLabel = new System.Windows.Forms.Label();
            this.CreateDiaryEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.AcceptsReturn = true;
            this.ContentTextBox.Location = new System.Drawing.Point(55, 102);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(600, 233);
            this.ContentTextBox.TabIndex = 3;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(52, 86);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 8;
            this.ContentLabel.Text = "Запись";
            // 
            // EntryDatePicker
            // 
            this.EntryDatePicker.Location = new System.Drawing.Point(55, 59);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EntryDatePicker.TabIndex = 9;
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(52, 43);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(72, 13);
            this.EntryDateLabel.TabIndex = 10;
            this.EntryDateLabel.Text = "Дата записи";
            // 
            // CreateDiaryEntryBtn
            // 
            this.CreateDiaryEntryBtn.Location = new System.Drawing.Point(255, 353);
            this.CreateDiaryEntryBtn.Name = "CreateDiaryEntryBtn";
            this.CreateDiaryEntryBtn.Size = new System.Drawing.Size(200, 36);
            this.CreateDiaryEntryBtn.TabIndex = 11;
            this.CreateDiaryEntryBtn.Text = "Подтвердить изменения";
            this.CreateDiaryEntryBtn.UseVisualStyleBackColor = true;
            this.CreateDiaryEntryBtn.Click += new System.EventHandler(this.CreateDiaryEntryBtn_Click);
            // 
            // CreateUpdateDiaryEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 430);
            this.Controls.Add(this.CreateDiaryEntryBtn);
            this.Controls.Add(this.EntryDateLabel);
            this.Controls.Add(this.EntryDatePicker);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ContentTextBox);
            this.Name = "CreateUpdateDiaryEntryForm";
            this.Text = "Создать/изменить запись в ежедневнике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.DateTimePicker EntryDatePicker;
        private System.Windows.Forms.Label EntryDateLabel;
        private System.Windows.Forms.Button CreateDiaryEntryBtn;
    }
}