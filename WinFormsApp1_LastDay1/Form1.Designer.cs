namespace WinFormsApp1_LastDay1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersTableDg = new System.Windows.Forms.DataGridView();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.loginAddTextBox = new System.Windows.Forms.TextBox();
            this.passwordAddTextBox = new System.Windows.Forms.TextBox();
            this.roleAddComboBox = new System.Windows.Forms.ComboBox();
            this.roleUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.passwordUpdateTextBox = new System.Windows.Forms.TextBox();
            this.loginUpdateTextBox = new System.Windows.Forms.TextBox();
            this.userUpdateBtn = new System.Windows.Forms.Button();
            this.getUserBtn = new System.Windows.Forms.Button();
            this.geleteUserBtn = new System.Windows.Forms.Button();
            this.searchUserBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableDg)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTableDg
            // 
            this.usersTableDg.AllowUserToAddRows = false;
            this.usersTableDg.AllowUserToDeleteRows = false;
            this.usersTableDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTableDg.Location = new System.Drawing.Point(65, 51);
            this.usersTableDg.Name = "usersTableDg";
            this.usersTableDg.ReadOnly = true;
            this.usersTableDg.RowHeadersWidth = 51;
            this.usersTableDg.RowTemplate.Height = 29;
            this.usersTableDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTableDg.Size = new System.Drawing.Size(980, 313);
            this.usersTableDg.TabIndex = 0;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(65, 546);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(94, 29);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Добавить";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // loginAddTextBox
            // 
            this.loginAddTextBox.Location = new System.Drawing.Point(65, 408);
            this.loginAddTextBox.Name = "loginAddTextBox";
            this.loginAddTextBox.Size = new System.Drawing.Size(151, 27);
            this.loginAddTextBox.TabIndex = 2;
            // 
            // passwordAddTextBox
            // 
            this.passwordAddTextBox.Location = new System.Drawing.Point(65, 452);
            this.passwordAddTextBox.Name = "passwordAddTextBox";
            this.passwordAddTextBox.Size = new System.Drawing.Size(151, 27);
            this.passwordAddTextBox.TabIndex = 3;
            // 
            // roleAddComboBox
            // 
            this.roleAddComboBox.FormattingEnabled = true;
            this.roleAddComboBox.Location = new System.Drawing.Point(65, 498);
            this.roleAddComboBox.Name = "roleAddComboBox";
            this.roleAddComboBox.Size = new System.Drawing.Size(151, 28);
            this.roleAddComboBox.TabIndex = 4;
            // 
            // roleUpdateComboBox
            // 
            this.roleUpdateComboBox.FormattingEnabled = true;
            this.roleUpdateComboBox.Location = new System.Drawing.Point(276, 498);
            this.roleUpdateComboBox.Name = "roleUpdateComboBox";
            this.roleUpdateComboBox.Size = new System.Drawing.Size(151, 28);
            this.roleUpdateComboBox.TabIndex = 8;
            // 
            // passwordUpdateTextBox
            // 
            this.passwordUpdateTextBox.Location = new System.Drawing.Point(276, 452);
            this.passwordUpdateTextBox.Name = "passwordUpdateTextBox";
            this.passwordUpdateTextBox.Size = new System.Drawing.Size(151, 27);
            this.passwordUpdateTextBox.TabIndex = 7;
            // 
            // loginUpdateTextBox
            // 
            this.loginUpdateTextBox.Location = new System.Drawing.Point(276, 408);
            this.loginUpdateTextBox.Name = "loginUpdateTextBox";
            this.loginUpdateTextBox.Size = new System.Drawing.Size(151, 27);
            this.loginUpdateTextBox.TabIndex = 6;
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.Location = new System.Drawing.Point(276, 546);
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.userUpdateBtn.TabIndex = 5;
            this.userUpdateBtn.Text = "Изменить";
            this.userUpdateBtn.UseVisualStyleBackColor = true;
            this.userUpdateBtn.Click += new System.EventHandler(this.userUpdateBtn_Click);
            // 
            // getUserBtn
            // 
            this.getUserBtn.Location = new System.Drawing.Point(484, 546);
            this.getUserBtn.Name = "getUserBtn";
            this.getUserBtn.Size = new System.Drawing.Size(94, 29);
            this.getUserBtn.TabIndex = 9;
            this.getUserBtn.Text = "Получить";
            this.getUserBtn.UseVisualStyleBackColor = true;
            this.getUserBtn.Click += new System.EventHandler(this.getUserBtn_Click);
            // 
            // geleteUserBtn
            // 
            this.geleteUserBtn.Location = new System.Drawing.Point(667, 546);
            this.geleteUserBtn.Name = "geleteUserBtn";
            this.geleteUserBtn.Size = new System.Drawing.Size(94, 29);
            this.geleteUserBtn.TabIndex = 10;
            this.geleteUserBtn.Text = "Удалить";
            this.geleteUserBtn.UseVisualStyleBackColor = true;
            this.geleteUserBtn.Click += new System.EventHandler(this.geleteUserBtn_Click);
            // 
            // searchUserBtn
            // 
            this.searchUserBtn.Location = new System.Drawing.Point(855, 546);
            this.searchUserBtn.Name = "searchUserBtn";
            this.searchUserBtn.Size = new System.Drawing.Size(94, 29);
            this.searchUserBtn.TabIndex = 11;
            this.searchUserBtn.Text = "Поиск";
            this.searchUserBtn.UseVisualStyleBackColor = true;
            this.searchUserBtn.Click += new System.EventHandler(this.searchUserBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(855, 408);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 27);
            this.searchTextBox.TabIndex = 12;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(484, 408);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 20);
            this.loginLabel.TabIndex = 13;
            this.loginLabel.Text = "label1";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(484, 452);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(50, 20);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "label2";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(484, 498);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(50, 20);
            this.roleLabel.TabIndex = 15;
            this.roleLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 615);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchUserBtn);
            this.Controls.Add(this.geleteUserBtn);
            this.Controls.Add(this.getUserBtn);
            this.Controls.Add(this.roleUpdateComboBox);
            this.Controls.Add(this.passwordUpdateTextBox);
            this.Controls.Add(this.loginUpdateTextBox);
            this.Controls.Add(this.userUpdateBtn);
            this.Controls.Add(this.roleAddComboBox);
            this.Controls.Add(this.passwordAddTextBox);
            this.Controls.Add(this.loginAddTextBox);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.usersTableDg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersTableDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView usersTableDg;
        private Button addUserBtn;
        private TextBox loginAddTextBox;
        private TextBox passwordAddTextBox;
        private ComboBox roleAddComboBox;
        private ComboBox roleUpdateComboBox;
        private TextBox passwordUpdateTextBox;
        private TextBox loginUpdateTextBox;
        private Button userUpdateBtn;
        private Button getUserBtn;
        private Button geleteUserBtn;
        private Button searchUserBtn;
        private TextBox searchTextBox;
        private Label loginLabel;
        private Label passwordLabel;
        private Label roleLabel;
    }
}