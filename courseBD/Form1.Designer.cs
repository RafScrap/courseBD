namespace courseBD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatingMongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.labelIncorrectLoginOrPassword = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelNameAndCategoryUser = new System.Windows.Forms.Label();
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userTableAdapter();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesToolStripMenuItem,
            this.обучениеToolStripMenuItem,
            this.testsToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.сервисыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.coursesToolStripMenuItem.Text = "Курсы";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // обучениеToolStripMenuItem
            // 
            this.обучениеToolStripMenuItem.Name = "обучениеToolStripMenuItem";
            this.обучениеToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.обучениеToolStripMenuItem.Text = "Обучение";
            this.обучениеToolStripMenuItem.Click += new System.EventHandler(this.learningToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.testsToolStripMenuItem.Text = "Тесты";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.resultsToolStripMenuItem.Text = "Результаты тестирования";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.dictionaryToolStripMenuItem.Text = "Справочники";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // сервисыToolStripMenuItem
            // 
            this.сервисыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatingMongoDBToolStripMenuItem});
            this.сервисыToolStripMenuItem.Name = "сервисыToolStripMenuItem";
            this.сервисыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.сервисыToolStripMenuItem.Text = "Сервисы";
            // 
            // creatingMongoDBToolStripMenuItem
            // 
            this.creatingMongoDBToolStripMenuItem.Name = "creatingMongoDBToolStripMenuItem";
            this.creatingMongoDBToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.creatingMongoDBToolStripMenuItem.Text = "Создание БД MongoDB";
            this.creatingMongoDBToolStripMenuItem.Click += new System.EventHandler(this.creatingMongoDBToolStripMenuItem_Click);
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.Controls.Add(this.labelIncorrectLoginOrPassword);
            this.groupBoxSignIn.Controls.Add(this.buttonInput);
            this.groupBoxSignIn.Controls.Add(this.label2);
            this.groupBoxSignIn.Controls.Add(this.label1);
            this.groupBoxSignIn.Controls.Add(this.textBoxPassword);
            this.groupBoxSignIn.Controls.Add(this.textBoxLogin);
            this.groupBoxSignIn.Location = new System.Drawing.Point(116, 94);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(397, 164);
            this.groupBoxSignIn.TabIndex = 1;
            this.groupBoxSignIn.TabStop = false;
            // 
            // labelIncorrectLoginOrPassword
            // 
            this.labelIncorrectLoginOrPassword.AutoSize = true;
            this.labelIncorrectLoginOrPassword.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectLoginOrPassword.Location = new System.Drawing.Point(18, 132);
            this.labelIncorrectLoginOrPassword.Name = "labelIncorrectLoginOrPassword";
            this.labelIncorrectLoginOrPassword.Size = new System.Drawing.Size(226, 16);
            this.labelIncorrectLoginOrPassword.TabIndex = 4;
            this.labelIncorrectLoginOrPassword.Text = "Неправильный логин или пароль!";
            this.labelIncorrectLoginOrPassword.Visible = false;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(293, 126);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(87, 32);
            this.buttonInput.TabIndex = 3;
            this.buttonInput.Text = "Ввод";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(123, 87);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(201, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "1";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(123, 45);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(201, 22);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Alex";
            // 
            // labelNameAndCategoryUser
            // 
            this.labelNameAndCategoryUser.AutoSize = true;
            this.labelNameAndCategoryUser.Location = new System.Drawing.Point(21, 61);
            this.labelNameAndCategoryUser.Name = "labelNameAndCategoryUser";
            this.labelNameAndCategoryUser.Size = new System.Drawing.Size(210, 16);
            this.labelNameAndCategoryUser.TabIndex = 2;
            this.labelNameAndCategoryUser.Text = "Имя и категория пользователя";
            this.labelNameAndCategoryUser.Visible = false;
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.learnEngDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(538, 50);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(101, 38);
            this.buttonSignOut.TabIndex = 3;
            this.buttonSignOut.Text = "Выход";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Visible = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 306);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.labelNameAndCategoryUser);
            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Информационная система обучения английскому языку";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelNameAndCategoryUser;
        private System.Windows.Forms.Label labelIncorrectLoginOrPassword;
        private System.Windows.Forms.Button buttonInput;
        private LearnEngDataSet learnEngDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LearnEngDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem сервисыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatingMongoDBToolStripMenuItem;
        private System.Windows.Forms.Button buttonSignOut;
    }
}

