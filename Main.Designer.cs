namespace RecordBookApp
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.ToFriendsListBtn = new System.Windows.Forms.Button();
            this.ToDiaryBtn = new System.Windows.Forms.Button();
            this.ToRemindersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(269, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Записная книжка";
            // 
            // ToFriendsListBtn
            // 
            this.ToFriendsListBtn.Location = new System.Drawing.Point(272, 139);
            this.ToFriendsListBtn.Name = "ToFriendsListBtn";
            this.ToFriendsListBtn.Size = new System.Drawing.Size(256, 50);
            this.ToFriendsListBtn.TabIndex = 1;
            this.ToFriendsListBtn.Text = "Список знакомых";
            this.ToFriendsListBtn.UseVisualStyleBackColor = true;
            this.ToFriendsListBtn.Click += new System.EventHandler(this.ToFriendsListBtn_Click);
            // 
            // ToDiaryBtn
            // 
            this.ToDiaryBtn.Location = new System.Drawing.Point(272, 209);
            this.ToDiaryBtn.Name = "ToDiaryBtn";
            this.ToDiaryBtn.Size = new System.Drawing.Size(256, 50);
            this.ToDiaryBtn.TabIndex = 2;
            this.ToDiaryBtn.Text = "Ежедневник";
            this.ToDiaryBtn.UseVisualStyleBackColor = true;
            // 
            // ToRemindersBtn
            // 
            this.ToRemindersBtn.Location = new System.Drawing.Point(272, 279);
            this.ToRemindersBtn.Name = "ToRemindersBtn";
            this.ToRemindersBtn.Size = new System.Drawing.Size(256, 50);
            this.ToRemindersBtn.TabIndex = 3;
            this.ToRemindersBtn.Text = "Напоминания";
            this.ToRemindersBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToRemindersBtn);
            this.Controls.Add(this.ToDiaryBtn);
            this.Controls.Add(this.ToFriendsListBtn);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Записная книжка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToFriendsListBtn;
        private System.Windows.Forms.Button ToDiaryBtn;
        private System.Windows.Forms.Button ToRemindersBtn;
    }
}

