
namespace Module_2
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.CheckBox();
            this.FirstName = new System.Windows.Forms.CheckBox();
            this.Patronymic = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.CheckBox();
            this.DateOfBirth = new System.Windows.Forms.CheckBox();
            this.DopInfo = new System.Windows.Forms.CheckBox();
            this.FamilyStatus = new System.Windows.Forms.CheckBox();
            this.ListUser = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 211);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(680, 84);
            this.listBox.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(95, 324);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 105);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // LastName
            // 
            this.LastName.AutoCheck = false;
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(257, 12);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 24);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Фамилия";
            this.LastName.UseVisualStyleBackColor = true;
            this.LastName.CheckedChanged += new System.EventHandler(this.LastName_CheckedChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoCheck = false;
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(257, 61);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(59, 24);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "Имя";
            this.FirstName.UseVisualStyleBackColor = true;
            this.FirstName.CheckedChanged += new System.EventHandler(this.FirstName_CheckedChanged);
            // 
            // Patronymic
            // 
            this.Patronymic.AutoCheck = false;
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.Location = new System.Drawing.Point(257, 106);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(102, 24);
            this.Patronymic.TabIndex = 4;
            this.Patronymic.Text = "Отчество";
            this.Patronymic.UseVisualStyleBackColor = true;
            this.Patronymic.CheckedChanged += new System.EventHandler(this.Patronymic_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.AutoCheck = false;
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(486, 12);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(59, 24);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Пол";
            this.Gender.UseVisualStyleBackColor = true;
            this.Gender.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoCheck = false;
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(486, 58);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(187, 27);
            this.DateOfBirth.TabIndex = 6;
            this.DateOfBirth.Text = "Год и дата рождения";
            this.DateOfBirth.UseVisualStyleBackColor = true;
            this.DateOfBirth.CheckedChanged += new System.EventHandler(this.DateOfBirth_CheckedChanged);
            // 
            // DopInfo
            // 
            this.DopInfo.AutoCheck = false;
            this.DopInfo.AutoSize = true;
            this.DopInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DopInfo.Location = new System.Drawing.Point(284, 161);
            this.DopInfo.Name = "DopInfo";
            this.DopInfo.Size = new System.Drawing.Size(261, 24);
            this.DopInfo.TabIndex = 7;
            this.DopInfo.Text = "Дополнительная информация";
            this.DopInfo.UseVisualStyleBackColor = true;
            this.DopInfo.CheckedChanged += new System.EventHandler(this.DopInfo_CheckedChanged);
            // 
            // FamilyStatus
            // 
            this.FamilyStatus.AutoCheck = false;
            this.FamilyStatus.AutoSize = true;
            this.FamilyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FamilyStatus.Location = new System.Drawing.Point(486, 106);
            this.FamilyStatus.Name = "FamilyStatus";
            this.FamilyStatus.Size = new System.Drawing.Size(160, 24);
            this.FamilyStatus.TabIndex = 8;
            this.FamilyStatus.Text = "Семейный статус";
            this.FamilyStatus.UseVisualStyleBackColor = true;
            this.FamilyStatus.CheckedChanged += new System.EventHandler(this.FamilyStatus_CheckedChanged);
            // 
            // ListUser
            // 
            this.ListUser.FormattingEnabled = true;
            this.ListUser.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3"});
            this.ListUser.Location = new System.Drawing.Point(21, 12);
            this.ListUser.Name = "ListUser";
            this.ListUser.Size = new System.Drawing.Size(178, 21);
            this.ListUser.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(413, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 107);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выделить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListUser);
            this.Controls.Add(this.FamilyStatus);
            this.Controls.Add(this.DopInfo);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox LastName;
        private System.Windows.Forms.CheckBox FirstName;
        private System.Windows.Forms.CheckBox Patronymic;
        private System.Windows.Forms.CheckBox Gender;
        private System.Windows.Forms.CheckBox DateOfBirth;
        private System.Windows.Forms.CheckBox DopInfo;
        private System.Windows.Forms.CheckBox FamilyStatus;
        private System.Windows.Forms.ComboBox ListUser;
        private System.Windows.Forms.Button button2;
    }
}

