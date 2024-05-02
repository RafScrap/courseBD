namespace courseBD
{
    partial class FormCreatingMongoDB
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
            this.labelChooseCourse = new System.Windows.Forms.Label();
            this.comboBoxChooseCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.buttonFillMongoDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathDB = new System.Windows.Forms.TextBox();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet7 = new courseBD.LearnEngDataSet();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet5 = new courseBD.LearnEngDataSet();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet3 = new courseBD.LearnEngDataSet();
            this.courseTopicFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet1 = new courseBD.LearnEngDataSet();
            this.courseTableAdapter = new courseBD.LearnEngDataSetTableAdapters.courseTableAdapter();
            this.courseTopicFullTableAdapter = new courseBD.LearnEngDataSetTableAdapters.courseTopicFullTableAdapter();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet2 = new courseBD.LearnEngDataSet();
            this.topicTableAdapter = new courseBD.LearnEngDataSetTableAdapters.topicTableAdapter();
            this.partTableAdapter = new courseBD.LearnEngDataSetTableAdapters.partTableAdapter();
            this.exampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet4 = new courseBD.LearnEngDataSet();
            this.exampleTableAdapter = new courseBD.LearnEngDataSetTableAdapters.exampleTableAdapter();
            this.testTableAdapter = new courseBD.LearnEngDataSetTableAdapters.testTableAdapter();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet6 = new courseBD.LearnEngDataSet();
            this.questionTableAdapter = new courseBD.LearnEngDataSetTableAdapters.questionTableAdapter();
            this.answerTableAdapter = new courseBD.LearnEngDataSetTableAdapters.answerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTopicFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseCourse
            // 
            this.labelChooseCourse.AutoSize = true;
            this.labelChooseCourse.Location = new System.Drawing.Point(36, 49);
            this.labelChooseCourse.Name = "labelChooseCourse";
            this.labelChooseCourse.Size = new System.Drawing.Size(41, 16);
            this.labelChooseCourse.TabIndex = 0;
            this.labelChooseCourse.Text = "Курс:";
            // 
            // comboBoxChooseCourse
            // 
            this.comboBoxChooseCourse.DataSource = this.courseBindingSource;
            this.comboBoxChooseCourse.DisplayMember = "nameCourse";
            this.comboBoxChooseCourse.FormattingEnabled = true;
            this.comboBoxChooseCourse.Location = new System.Drawing.Point(101, 46);
            this.comboBoxChooseCourse.Name = "comboBoxChooseCourse";
            this.comboBoxChooseCourse.Size = new System.Drawing.Size(287, 24);
            this.comboBoxChooseCourse.TabIndex = 1;
            this.comboBoxChooseCourse.ValueMember = "ID";
            this.comboBoxChooseCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCourse_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.learnEngDataSet;
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonFillMongoDB
            // 
            this.buttonFillMongoDB.Location = new System.Drawing.Point(434, 35);
            this.buttonFillMongoDB.Name = "buttonFillMongoDB";
            this.buttonFillMongoDB.Size = new System.Drawing.Size(130, 45);
            this.buttonFillMongoDB.TabIndex = 2;
            this.buttonFillMongoDB.Text = "Заполнить MongoDB";
            this.buttonFillMongoDB.UseVisualStyleBackColor = true;
            this.buttonFillMongoDB.Click += new System.EventHandler(this.buttonFillMongoDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь до БД:";
            // 
            // textBoxPathDB
            // 
            this.textBoxPathDB.Location = new System.Drawing.Point(121, 85);
            this.textBoxPathDB.Name = "textBoxPathDB";
            this.textBoxPathDB.Size = new System.Drawing.Size(287, 22);
            this.textBoxPathDB.TabIndex = 4;
            this.textBoxPathDB.Text = "mongodb://localhost:27017";
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataMember = "answer";
            this.answerBindingSource.DataSource = this.learnEngDataSet7;
            // 
            // learnEngDataSet7
            // 
            this.learnEngDataSet7.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.learnEngDataSet5;
            // 
            // learnEngDataSet5
            // 
            this.learnEngDataSet5.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "part";
            this.partBindingSource.DataSource = this.learnEngDataSet3;
            // 
            // learnEngDataSet3
            // 
            this.learnEngDataSet3.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTopicFullBindingSource
            // 
            this.courseTopicFullBindingSource.DataMember = "courseTopicFull";
            this.courseTopicFullBindingSource.DataSource = this.learnEngDataSet1;
            // 
            // learnEngDataSet1
            // 
            this.learnEngDataSet1.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseTopicFullTableAdapter
            // 
            this.courseTopicFullTableAdapter.ClearBeforeFill = true;
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataMember = "topic";
            this.topicBindingSource.DataSource = this.learnEngDataSet2;
            // 
            // learnEngDataSet2
            // 
            this.learnEngDataSet2.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicTableAdapter
            // 
            this.topicTableAdapter.ClearBeforeFill = true;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // exampleBindingSource
            // 
            this.exampleBindingSource.DataMember = "example";
            this.exampleBindingSource.DataSource = this.learnEngDataSet4;
            // 
            // learnEngDataSet4
            // 
            this.learnEngDataSet4.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exampleTableAdapter
            // 
            this.exampleTableAdapter.ClearBeforeFill = true;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.learnEngDataSet6;
            // 
            // learnEngDataSet6
            // 
            this.learnEngDataSet6.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // FormCreatingMongoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 135);
            this.Controls.Add(this.textBoxPathDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFillMongoDB);
            this.Controls.Add(this.comboBoxChooseCourse);
            this.Controls.Add(this.labelChooseCourse);
            this.Name = "FormCreatingMongoDB";
            this.Text = "Сервис";
            this.Load += new System.EventHandler(this.FormCreatingMongoDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTopicFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseCourse;
        private System.Windows.Forms.ComboBox comboBoxChooseCourse;
        private System.Windows.Forms.Button buttonFillMongoDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathDB;
        private LearnEngDataSet learnEngDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private LearnEngDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseTopicFullBindingSource;
        private LearnEngDataSetTableAdapters.courseTopicFullTableAdapter courseTopicFullTableAdapter;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private LearnEngDataSetTableAdapters.topicTableAdapter topicTableAdapter;
        private System.Windows.Forms.BindingSource partBindingSource;
        private LearnEngDataSet learnEngDataSet3;
        private LearnEngDataSet learnEngDataSet1;
        private LearnEngDataSet learnEngDataSet2;
        private LearnEngDataSetTableAdapters.partTableAdapter partTableAdapter;
        private System.Windows.Forms.BindingSource exampleBindingSource;
        private LearnEngDataSetTableAdapters.exampleTableAdapter exampleTableAdapter;
        private LearnEngDataSet learnEngDataSet4;
        private System.Windows.Forms.BindingSource testBindingSource;
        private LearnEngDataSetTableAdapters.testTableAdapter testTableAdapter;
        private LearnEngDataSet learnEngDataSet5;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private LearnEngDataSet learnEngDataSet6;
        private LearnEngDataSetTableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.BindingSource answerBindingSource;
        private LearnEngDataSetTableAdapters.answerTableAdapter answerTableAdapter;
        private LearnEngDataSet learnEngDataSet7;
    }
}