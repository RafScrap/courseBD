namespace courseBD
{
    partial class FormDictionary
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxChangeUser = new System.Windows.Forms.GroupBox();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.textBoxChangePassword = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.textBoxChangeUser = new System.Windows.Forms.TextBox();
            this.labelChangeUser = new System.Windows.Forms.Label();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.labelAddPassword = new System.Windows.Forms.Label();
            this.textBoxlAddPassword = new System.Windows.Forms.TextBox();
            this.labelAddUserCategory = new System.Windows.Forms.Label();
            this.comboBoxAddUserCategory = new System.Windows.Forms.ComboBox();
            this.userCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxAddUser = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelAddUser = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.userTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userTableAdapter();
            this.userCategoryTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userCategoryTableAdapter();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUserCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxChangeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            this.groupBoxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxChangeUser);
            this.tabPage1.Controls.Add(this.groupBoxAddUser);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxChangeUser
            // 
            this.groupBoxChangeUser.Controls.Add(this.labelChangePassword);
            this.groupBoxChangeUser.Controls.Add(this.textBoxChangePassword);
            this.groupBoxChangeUser.Controls.Add(this.buttonDeleteUser);
            this.groupBoxChangeUser.Controls.Add(this.buttonChangeUser);
            this.groupBoxChangeUser.Controls.Add(this.textBoxChangeUser);
            this.groupBoxChangeUser.Controls.Add(this.labelChangeUser);
            this.groupBoxChangeUser.Location = new System.Drawing.Point(7, 383);
            this.groupBoxChangeUser.Name = "groupBoxChangeUser";
            this.groupBoxChangeUser.Size = new System.Drawing.Size(784, 100);
            this.groupBoxChangeUser.TabIndex = 8;
            this.groupBoxChangeUser.TabStop = false;
            this.groupBoxChangeUser.Text = "Изменить и удалить пользователя";
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Location = new System.Drawing.Point(286, 18);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(59, 16);
            this.labelChangePassword.TabIndex = 7;
            this.labelChangePassword.Text = "Пароль:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.learnEngDataSet;
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxChangePassword
            // 
            this.textBoxChangePassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.textBoxChangePassword.Location = new System.Drawing.Point(289, 53);
            this.textBoxChangePassword.Name = "textBoxChangePassword";
            this.textBoxChangePassword.Size = new System.Drawing.Size(212, 22);
            this.textBoxChangePassword.TabIndex = 7;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(675, 40);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(92, 35);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Location = new System.Drawing.Point(559, 40);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(99, 35);
            this.buttonChangeUser.TabIndex = 3;
            this.buttonChangeUser.Text = "Изменить";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // textBoxChangeUser
            // 
            this.textBoxChangeUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "nameUser", true));
            this.textBoxChangeUser.Location = new System.Drawing.Point(18, 53);
            this.textBoxChangeUser.Name = "textBoxChangeUser";
            this.textBoxChangeUser.Size = new System.Drawing.Size(242, 22);
            this.textBoxChangeUser.TabIndex = 3;
            // 
            // labelChangeUser
            // 
            this.labelChangeUser.AutoSize = true;
            this.labelChangeUser.Location = new System.Drawing.Point(16, 34);
            this.labelChangeUser.Name = "labelChangeUser";
            this.labelChangeUser.Size = new System.Drawing.Size(132, 16);
            this.labelChangeUser.TabIndex = 3;
            this.labelChangeUser.Text = "Имя пользователя:";
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.labelAddPassword);
            this.groupBoxAddUser.Controls.Add(this.textBoxlAddPassword);
            this.groupBoxAddUser.Controls.Add(this.labelAddUserCategory);
            this.groupBoxAddUser.Controls.Add(this.comboBoxAddUserCategory);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddUser);
            this.groupBoxAddUser.Controls.Add(this.buttonAddUser);
            this.groupBoxAddUser.Controls.Add(this.labelAddUser);
            this.groupBoxAddUser.Location = new System.Drawing.Point(3, 283);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(788, 90);
            this.groupBoxAddUser.TabIndex = 7;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Добавить пользователя";
            // 
            // labelAddPassword
            // 
            this.labelAddPassword.AutoSize = true;
            this.labelAddPassword.Location = new System.Drawing.Point(446, 22);
            this.labelAddPassword.Name = "labelAddPassword";
            this.labelAddPassword.Size = new System.Drawing.Size(59, 16);
            this.labelAddPassword.TabIndex = 6;
            this.labelAddPassword.Text = "Пароль:";
            // 
            // textBoxlAddPassword
            // 
            this.textBoxlAddPassword.Location = new System.Drawing.Point(449, 47);
            this.textBoxlAddPassword.Name = "textBoxlAddPassword";
            this.textBoxlAddPassword.Size = new System.Drawing.Size(197, 22);
            this.textBoxlAddPassword.TabIndex = 5;
            // 
            // labelAddUserCategory
            // 
            this.labelAddUserCategory.AutoSize = true;
            this.labelAddUserCategory.Location = new System.Drawing.Point(290, 22);
            this.labelAddUserCategory.Name = "labelAddUserCategory";
            this.labelAddUserCategory.Size = new System.Drawing.Size(78, 16);
            this.labelAddUserCategory.TabIndex = 4;
            this.labelAddUserCategory.Text = "Категория:";
            // 
            // comboBoxAddUserCategory
            // 
            this.comboBoxAddUserCategory.DataSource = this.userCategoryBindingSource;
            this.comboBoxAddUserCategory.DisplayMember = "nameUserCategory";
            this.comboBoxAddUserCategory.FormattingEnabled = true;
            this.comboBoxAddUserCategory.Location = new System.Drawing.Point(293, 47);
            this.comboBoxAddUserCategory.Name = "comboBoxAddUserCategory";
            this.comboBoxAddUserCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAddUserCategory.TabIndex = 3;
            this.comboBoxAddUserCategory.ValueMember = "ID";
            // 
            // userCategoryBindingSource
            // 
            this.userCategoryBindingSource.DataMember = "userCategory";
            this.userCategoryBindingSource.DataSource = this.learnEngDataSet;
            // 
            // textBoxAddUser
            // 
            this.textBoxAddUser.Location = new System.Drawing.Point(22, 49);
            this.textBoxAddUser.Name = "textBoxAddUser";
            this.textBoxAddUser.Size = new System.Drawing.Size(242, 22);
            this.textBoxAddUser.TabIndex = 2;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(661, 34);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(110, 35);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelAddUser
            // 
            this.labelAddUser.AutoSize = true;
            this.labelAddUser.Location = new System.Drawing.Point(20, 26);
            this.labelAddUser.Name = "labelAddUser";
            this.labelAddUser.Size = new System.Drawing.Size(132, 16);
            this.labelAddUser.TabIndex = 0;
            this.labelAddUser.Text = "Имя пользователя:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameUserDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameUserCategoryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.userBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(766, 252);
            this.dataGridView2.TabIndex = 6;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userCategoryTableAdapter
            // 
            this.userCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "nameUser";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameUserCategoryDataGridViewTextBoxColumn
            // 
            this.nameUserCategoryDataGridViewTextBoxColumn.DataPropertyName = "nameUserCategory";
            this.nameUserCategoryDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.nameUserCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameUserCategoryDataGridViewTextBoxColumn.Name = "nameUserCategoryDataGridViewTextBoxColumn";
            this.nameUserCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDictionary";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.FormDictionary_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxChangeUser.ResumeLayout(false);
            this.groupBoxChangeUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Label labelAddUserCategory;
        private System.Windows.Forms.ComboBox comboBoxAddUserCategory;
        private System.Windows.Forms.TextBox textBoxAddUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelAddUser;
        private System.Windows.Forms.GroupBox groupBoxChangeUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.TextBox textBoxChangeUser;
        private System.Windows.Forms.Label labelChangeUser;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.TextBox textBoxChangePassword;
        private System.Windows.Forms.Label labelAddPassword;
        private System.Windows.Forms.TextBox textBoxlAddPassword;
        private LearnEngDataSet learnEngDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LearnEngDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userCategoryBindingSource;
        private LearnEngDataSetTableAdapters.userCategoryTableAdapter userCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserCategoryDataGridViewTextBoxColumn;
    }
}