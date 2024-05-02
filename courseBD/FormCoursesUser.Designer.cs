namespace courseBD
{
    partial class FormCoursesUser
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
            this.comboBoxChooseCourse = new System.Windows.Forms.ComboBox();
            this.courseUserFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.comboBoxChooseTopic = new System.Windows.Forms.ComboBox();
            this.courseTopicFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet0 = new courseBD.LearnEngDataSet();
            this.courseUserFullTableAdapter = new courseBD.LearnEngDataSetTableAdapters.courseUserFullTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTextPart = new System.Windows.Forms.TextBox();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet1 = new courseBD.LearnEngDataSet();
            this.dataGridViewChoosePart = new System.Windows.Forms.DataGridView();
            this.numPartInTopicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxExamples = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLearning = new System.Windows.Forms.TabPage();
            this.buttonRefreshTopic = new System.Windows.Forms.Button();
            this.labelExamples = new System.Windows.Forms.Label();
            this.labelTextPart = new System.Windows.Forms.Label();
            this.labelTextTopic = new System.Windows.Forms.Label();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.dataGridViewChooseTests = new System.Windows.Forms.DataGridView();
            this.groupBoxChooseTestType = new System.Windows.Forms.GroupBox();
            this.radioButtonTestTypeUnlinked = new System.Windows.Forms.RadioButton();
            this.radioButtonTestTypeTopic = new System.Windows.Forms.RadioButton();
            this.radioButtonTestTypeCourse = new System.Windows.Forms.RadioButton();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.learnEngDataSet4 = new courseBD.LearnEngDataSet();
            this.userUnlinkedTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet3 = new courseBD.LearnEngDataSet();
            this.userUnlinkedTestTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userUnlinkedTestTableAdapter();
            this.partTableAdapter = new courseBD.LearnEngDataSetTableAdapters.partTableAdapter();
            this.learnEngDataSet2 = new courseBD.LearnEngDataSet();
            this.getExamples2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExamples2TableAdapter = new courseBD.LearnEngDataSetTableAdapters.GetExamples2TableAdapter();
            this.courseTopicFullTableAdapter = new courseBD.LearnEngDataSetTableAdapters.courseTopicFullTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new courseBD.LearnEngDataSetTableAdapters.testTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseUserFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTopicFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosePart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLearning.SuspendLayout();
            this.tabPageTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChooseTests)).BeginInit();
            this.groupBoxChooseTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUnlinkedTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamples2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseCourse
            // 
            this.comboBoxChooseCourse.DataSource = this.courseUserFullBindingSource;
            this.comboBoxChooseCourse.DisplayMember = "nameCourse";
            this.comboBoxChooseCourse.FormattingEnabled = true;
            this.comboBoxChooseCourse.Location = new System.Drawing.Point(68, 12);
            this.comboBoxChooseCourse.Name = "comboBoxChooseCourse";
            this.comboBoxChooseCourse.Size = new System.Drawing.Size(384, 24);
            this.comboBoxChooseCourse.TabIndex = 0;
            this.comboBoxChooseCourse.ValueMember = "IDCourse";
            this.comboBoxChooseCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCourse_SelectedIndexChanged);
            // 
            // courseUserFullBindingSource
            // 
            this.courseUserFullBindingSource.DataMember = "courseUserFull";
            this.courseUserFullBindingSource.DataSource = this.learnEngDataSet;
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxChooseTopic
            // 
            this.comboBoxChooseTopic.DataSource = this.courseTopicFullBindingSource;
            this.comboBoxChooseTopic.DisplayMember = "nameTopic";
            this.comboBoxChooseTopic.FormattingEnabled = true;
            this.comboBoxChooseTopic.Location = new System.Drawing.Point(503, 12);
            this.comboBoxChooseTopic.Name = "comboBoxChooseTopic";
            this.comboBoxChooseTopic.Size = new System.Drawing.Size(380, 24);
            this.comboBoxChooseTopic.TabIndex = 1;
            this.comboBoxChooseTopic.ValueMember = "IDTopic";
            this.comboBoxChooseTopic.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseTopic_SelectedIndexChanged);
            // 
            // courseTopicFullBindingSource
            // 
            this.courseTopicFullBindingSource.DataMember = "courseTopicFull";
            this.courseTopicFullBindingSource.DataSource = this.learnEngDataSet0;
            // 
            // learnEngDataSet0
            // 
            this.learnEngDataSet0.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseUserFullTableAdapter
            // 
            this.courseUserFullTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseTopicFullBindingSource, "textTopic", true));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 128);
            this.textBox1.TabIndex = 4;
            // 
            // textBoxTextPart
            // 
            this.textBoxTextPart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "textPart", true));
            this.textBoxTextPart.Location = new System.Drawing.Point(456, 35);
            this.textBoxTextPart.Multiline = true;
            this.textBoxTextPart.Name = "textBoxTextPart";
            this.textBoxTextPart.Size = new System.Drawing.Size(404, 128);
            this.textBoxTextPart.TabIndex = 9;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "part";
            this.partBindingSource.DataSource = this.learnEngDataSet1;
            // 
            // learnEngDataSet1
            // 
            this.learnEngDataSet1.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewChoosePart
            // 
            this.dataGridViewChoosePart.AutoGenerateColumns = false;
            this.dataGridViewChoosePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoosePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPartInTopicDataGridViewTextBoxColumn,
            this.headerPartDataGridViewTextBoxColumn,
            this.textPartDataGridViewTextBoxColumn});
            this.dataGridViewChoosePart.DataSource = this.partBindingSource;
            this.dataGridViewChoosePart.Location = new System.Drawing.Point(6, 205);
            this.dataGridViewChoosePart.Name = "dataGridViewChoosePart";
            this.dataGridViewChoosePart.RowHeadersWidth = 51;
            this.dataGridViewChoosePart.RowTemplate.Height = 24;
            this.dataGridViewChoosePart.Size = new System.Drawing.Size(440, 172);
            this.dataGridViewChoosePart.TabIndex = 10;
            this.dataGridViewChoosePart.SelectionChanged += new System.EventHandler(this.dataGridViewChoosePart_SelectionChanged);
            // 
            // numPartInTopicDataGridViewTextBoxColumn
            // 
            this.numPartInTopicDataGridViewTextBoxColumn.DataPropertyName = "numPartInTopic";
            this.numPartInTopicDataGridViewTextBoxColumn.HeaderText = "№";
            this.numPartInTopicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numPartInTopicDataGridViewTextBoxColumn.Name = "numPartInTopicDataGridViewTextBoxColumn";
            this.numPartInTopicDataGridViewTextBoxColumn.Width = 50;
            // 
            // headerPartDataGridViewTextBoxColumn
            // 
            this.headerPartDataGridViewTextBoxColumn.DataPropertyName = "headerPart";
            this.headerPartDataGridViewTextBoxColumn.HeaderText = "Заголовок";
            this.headerPartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headerPartDataGridViewTextBoxColumn.Name = "headerPartDataGridViewTextBoxColumn";
            this.headerPartDataGridViewTextBoxColumn.Width = 125;
            // 
            // textPartDataGridViewTextBoxColumn
            // 
            this.textPartDataGridViewTextBoxColumn.DataPropertyName = "textPart";
            this.textPartDataGridViewTextBoxColumn.HeaderText = "Текст";
            this.textPartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textPartDataGridViewTextBoxColumn.Name = "textPartDataGridViewTextBoxColumn";
            this.textPartDataGridViewTextBoxColumn.Width = 200;
            // 
            // textBoxExamples
            // 
            this.textBoxExamples.Location = new System.Drawing.Point(456, 188);
            this.textBoxExamples.Multiline = true;
            this.textBoxExamples.Name = "textBoxExamples";
            this.textBoxExamples.Size = new System.Drawing.Size(404, 189);
            this.textBoxExamples.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLearning);
            this.tabControl1.Controls.Add(this.tabPageTests);
            this.tabControl1.Location = new System.Drawing.Point(2, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 409);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageLearning
            // 
            this.tabPageLearning.Controls.Add(this.buttonRefreshTopic);
            this.tabPageLearning.Controls.Add(this.labelExamples);
            this.tabPageLearning.Controls.Add(this.labelTextPart);
            this.tabPageLearning.Controls.Add(this.labelTextTopic);
            this.tabPageLearning.Controls.Add(this.textBoxExamples);
            this.tabPageLearning.Controls.Add(this.textBoxTextPart);
            this.tabPageLearning.Controls.Add(this.dataGridViewChoosePart);
            this.tabPageLearning.Controls.Add(this.textBox1);
            this.tabPageLearning.Location = new System.Drawing.Point(4, 25);
            this.tabPageLearning.Name = "tabPageLearning";
            this.tabPageLearning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearning.Size = new System.Drawing.Size(877, 380);
            this.tabPageLearning.TabIndex = 0;
            this.tabPageLearning.Text = "Обучение";
            this.tabPageLearning.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshTopic
            // 
            this.buttonRefreshTopic.Location = new System.Drawing.Point(297, 169);
            this.buttonRefreshTopic.Name = "buttonRefreshTopic";
            this.buttonRefreshTopic.Size = new System.Drawing.Size(149, 30);
            this.buttonRefreshTopic.TabIndex = 17;
            this.buttonRefreshTopic.Text = "Обновить разделы";
            this.buttonRefreshTopic.UseVisualStyleBackColor = true;
            this.buttonRefreshTopic.Click += new System.EventHandler(this.buttonRefreshTopic_Click);
            // 
            // labelExamples
            // 
            this.labelExamples.AutoSize = true;
            this.labelExamples.Location = new System.Drawing.Point(453, 169);
            this.labelExamples.Name = "labelExamples";
            this.labelExamples.Size = new System.Drawing.Size(70, 16);
            this.labelExamples.TabIndex = 16;
            this.labelExamples.Text = "Примеры:";
            // 
            // labelTextPart
            // 
            this.labelTextPart.AutoSize = true;
            this.labelTextPart.Location = new System.Drawing.Point(453, 13);
            this.labelTextPart.Name = "labelTextPart";
            this.labelTextPart.Size = new System.Drawing.Size(134, 16);
            this.labelTextPart.TabIndex = 15;
            this.labelTextPart.Text = "Описание раздела:";
            // 
            // labelTextTopic
            // 
            this.labelTextTopic.AutoSize = true;
            this.labelTextTopic.Location = new System.Drawing.Point(12, 13);
            this.labelTextTopic.Name = "labelTextTopic";
            this.labelTextTopic.Size = new System.Drawing.Size(111, 16);
            this.labelTextTopic.TabIndex = 14;
            this.labelTextTopic.Text = "Описание темы:";
            // 
            // tabPageTests
            // 
            this.tabPageTests.Controls.Add(this.buttonStartTest);
            this.tabPageTests.Controls.Add(this.dataGridViewChooseTests);
            this.tabPageTests.Controls.Add(this.groupBoxChooseTestType);
            this.tabPageTests.Location = new System.Drawing.Point(4, 25);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTests.Size = new System.Drawing.Size(877, 380);
            this.tabPageTests.TabIndex = 1;
            this.tabPageTests.Text = "Тесты";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(672, 27);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(121, 36);
            this.buttonStartTest.TabIndex = 5;
            this.buttonStartTest.Text = "Начать тест";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // dataGridViewChooseTests
            // 
            this.dataGridViewChooseTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChooseTests.Location = new System.Drawing.Point(15, 74);
            this.dataGridViewChooseTests.Name = "dataGridViewChooseTests";
            this.dataGridViewChooseTests.RowHeadersWidth = 51;
            this.dataGridViewChooseTests.RowTemplate.Height = 24;
            this.dataGridViewChooseTests.Size = new System.Drawing.Size(856, 297);
            this.dataGridViewChooseTests.TabIndex = 4;
            this.dataGridViewChooseTests.SelectionChanged += new System.EventHandler(this.dataGridViewChooseTests_SelectionChanged);
            // 
            // groupBoxChooseTestType
            // 
            this.groupBoxChooseTestType.Controls.Add(this.radioButtonTestTypeUnlinked);
            this.groupBoxChooseTestType.Controls.Add(this.radioButtonTestTypeTopic);
            this.groupBoxChooseTestType.Controls.Add(this.radioButtonTestTypeCourse);
            this.groupBoxChooseTestType.Location = new System.Drawing.Point(25, 6);
            this.groupBoxChooseTestType.Name = "groupBoxChooseTestType";
            this.groupBoxChooseTestType.Size = new System.Drawing.Size(372, 62);
            this.groupBoxChooseTestType.TabIndex = 1;
            this.groupBoxChooseTestType.TabStop = false;
            this.groupBoxChooseTestType.Text = "Выберите тип теста";
            // 
            // radioButtonTestTypeUnlinked
            // 
            this.radioButtonTestTypeUnlinked.AutoSize = true;
            this.radioButtonTestTypeUnlinked.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonTestTypeUnlinked.Location = new System.Drawing.Point(216, 21);
            this.radioButtonTestTypeUnlinked.Name = "radioButtonTestTypeUnlinked";
            this.radioButtonTestTypeUnlinked.Size = new System.Drawing.Size(116, 36);
            this.radioButtonTestTypeUnlinked.TabIndex = 2;
            this.radioButtonTestTypeUnlinked.TabStop = true;
            this.radioButtonTestTypeUnlinked.Text = "Отдельный тест";
            this.radioButtonTestTypeUnlinked.UseVisualStyleBackColor = true;
            this.radioButtonTestTypeUnlinked.CheckedChanged += new System.EventHandler(this.radioButtonTestTypeUnlinked_CheckedChanged);
            // 
            // radioButtonTestTypeTopic
            // 
            this.radioButtonTestTypeTopic.AutoSize = true;
            this.radioButtonTestTypeTopic.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonTestTypeTopic.Location = new System.Drawing.Point(108, 24);
            this.radioButtonTestTypeTopic.Name = "radioButtonTestTypeTopic";
            this.radioButtonTestTypeTopic.Size = new System.Drawing.Size(96, 36);
            this.radioButtonTestTypeTopic.TabIndex = 1;
            this.radioButtonTestTypeTopic.TabStop = true;
            this.radioButtonTestTypeTopic.Text = "Тест по теме";
            this.radioButtonTestTypeTopic.UseVisualStyleBackColor = true;
            this.radioButtonTestTypeTopic.CheckedChanged += new System.EventHandler(this.radioButtonTestTypeTopic_CheckedChanged);
            // 
            // radioButtonTestTypeCourse
            // 
            this.radioButtonTestTypeCourse.AutoSize = true;
            this.radioButtonTestTypeCourse.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonTestTypeCourse.Location = new System.Drawing.Point(0, 24);
            this.radioButtonTestTypeCourse.Name = "radioButtonTestTypeCourse";
            this.radioButtonTestTypeCourse.Size = new System.Drawing.Size(102, 36);
            this.radioButtonTestTypeCourse.TabIndex = 0;
            this.radioButtonTestTypeCourse.TabStop = true;
            this.radioButtonTestTypeCourse.Text = "Тест по курсу";
            this.radioButtonTestTypeCourse.UseVisualStyleBackColor = true;
            this.radioButtonTestTypeCourse.CheckedChanged += new System.EventHandler(this.radioButtonTestTypeCourse_CheckedChanged);
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(455, 15);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(44, 16);
            this.labelTopic.TabIndex = 13;
            this.labelTopic.Text = "Тема:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(18, 15);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(41, 16);
            this.labelCourse.TabIndex = 12;
            this.labelCourse.Text = "Курс:";
            // 
            // learnEngDataSet4
            // 
            this.learnEngDataSet4.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userUnlinkedTestBindingSource
            // 
            this.userUnlinkedTestBindingSource.DataMember = "userUnlinkedTest";
            this.userUnlinkedTestBindingSource.DataSource = this.learnEngDataSet3;
            // 
            // learnEngDataSet3
            // 
            this.learnEngDataSet3.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userUnlinkedTestTableAdapter
            // 
            this.userUnlinkedTestTableAdapter.ClearBeforeFill = true;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // learnEngDataSet2
            // 
            this.learnEngDataSet2.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getExamples2BindingSource
            // 
            this.getExamples2BindingSource.DataMember = "GetExamples2";
            this.getExamples2BindingSource.DataSource = this.learnEngDataSet2;
            // 
            // getExamples2TableAdapter
            // 
            this.getExamples2TableAdapter.ClearBeforeFill = true;
            // 
            // courseTopicFullTableAdapter
            // 
            this.courseTopicFullTableAdapter.ClearBeforeFill = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.learnEngDataSet4;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // FormCoursesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.comboBoxChooseCourse);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.comboBoxChooseTopic);
            this.Name = "FormCoursesUser";
            this.Text = "Обучение и тесты";
            this.Load += new System.EventHandler(this.FormCoursesUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseUserFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTopicFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosePart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLearning.ResumeLayout(false);
            this.tabPageLearning.PerformLayout();
            this.tabPageTests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChooseTests)).EndInit();
            this.groupBoxChooseTestType.ResumeLayout(false);
            this.groupBoxChooseTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUnlinkedTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamples2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseCourse;
        private System.Windows.Forms.ComboBox comboBoxChooseTopic;
        private System.Windows.Forms.BindingSource courseUserFullBindingSource;
        private LearnEngDataSet learnEngDataSet;
        private LearnEngDataSetTableAdapters.courseUserFullTableAdapter courseUserFullTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTextPart;
        private System.Windows.Forms.DataGridView dataGridViewChoosePart;
       private System.Windows.Forms.TextBox textBoxExamples;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLearning;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelExamples;
        private System.Windows.Forms.Label labelTextPart;
        private System.Windows.Forms.Label labelTextTopic;
        private System.Windows.Forms.GroupBox groupBoxChooseTestType;
        private System.Windows.Forms.RadioButton radioButtonTestTypeCourse;
        private System.Windows.Forms.RadioButton radioButtonTestTypeUnlinked;
        private System.Windows.Forms.RadioButton radioButtonTestTypeTopic;
        private System.Windows.Forms.DataGridView dataGridViewChooseTests;
        private System.Windows.Forms.BindingSource userUnlinkedTestBindingSource;
        private LearnEngDataSetTableAdapters.userUnlinkedTestTableAdapter userUnlinkedTestTableAdapter;
        private System.Windows.Forms.BindingSource partBindingSource;
        private LearnEngDataSetTableAdapters.partTableAdapter partTableAdapter;
        private LearnEngDataSet learnEngDataSet1;
        private LearnEngDataSet learnEngDataSet2;
        private System.Windows.Forms.BindingSource getExamples2BindingSource;
        private LearnEngDataSetTableAdapters.GetExamples2TableAdapter getExamples2TableAdapter;
        private LearnEngDataSet learnEngDataSet3;
        private System.Windows.Forms.Button buttonRefreshTopic;
        private LearnEngDataSet learnEngDataSet4;
        private System.Windows.Forms.BindingSource courseTopicFullBindingSource;
        private LearnEngDataSetTableAdapters.courseTopicFullTableAdapter courseTopicFullTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private LearnEngDataSetTableAdapters.testTableAdapter testTableAdapter;
        private LearnEngDataSet learnEngDataSet0;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPartInTopicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerPartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textPartDataGridViewTextBoxColumn;
    }
}