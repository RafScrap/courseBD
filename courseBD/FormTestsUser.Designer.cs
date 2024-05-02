namespace courseBD
{
    partial class FormTestsUser
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
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new courseBD.LearnEngDataSetTableAdapters.questionTableAdapter();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.answerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRightColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonSaveAnswers = new System.Windows.Forms.Button();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet1 = new courseBD.LearnEngDataSet();
            this.answerTableAdapter = new courseBD.LearnEngDataSetTableAdapters.answerTableAdapter();
            this.labelResult = new System.Windows.Forms.Label();
            this.userTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet2 = new courseBD.LearnEngDataSet();
            this.userTestTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userTestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.learnEngDataSet;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Location = new System.Drawing.Point(12, 12);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(582, 176);
            this.textBoxQuestionText.TabIndex = 0;
            // 
            // dataGridViewAnswers
            // 
            this.dataGridViewAnswers.AllowUserToAddRows = false;
            this.dataGridViewAnswers.AllowUserToDeleteRows = false;
            this.dataGridViewAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answerColumn,
            this.isRightColumn});
            this.dataGridViewAnswers.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewAnswers.Name = "dataGridViewAnswers";
            this.dataGridViewAnswers.RowHeadersWidth = 51;
            this.dataGridViewAnswers.RowTemplate.Height = 24;
            this.dataGridViewAnswers.Size = new System.Drawing.Size(586, 168);
            this.dataGridViewAnswers.TabIndex = 1;
            // 
            // answerColumn
            // 
            this.answerColumn.Frozen = true;
            this.answerColumn.HeaderText = "Ответ";
            this.answerColumn.MinimumWidth = 6;
            this.answerColumn.Name = "answerColumn";
            this.answerColumn.ReadOnly = true;
            this.answerColumn.Width = 200;
            // 
            // isRightColumn
            // 
            this.isRightColumn.Frozen = true;
            this.isRightColumn.HeaderText = "Отметьте верный(ые) ответ(ы)";
            this.isRightColumn.MinimumWidth = 6;
            this.isRightColumn.Name = "isRightColumn";
            this.isRightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isRightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isRightColumn.Width = 200;
            // 
            // buttonSaveAnswers
            // 
            this.buttonSaveAnswers.Location = new System.Drawing.Point(12, 369);
            this.buttonSaveAnswers.Name = "buttonSaveAnswers";
            this.buttonSaveAnswers.Size = new System.Drawing.Size(586, 41);
            this.buttonSaveAnswers.TabIndex = 2;
            this.buttonSaveAnswers.Text = "Сохранить ответы и перейти в следующему вопросу";
            this.buttonSaveAnswers.UseVisualStyleBackColor = true;
            this.buttonSaveAnswers.Click += new System.EventHandler(this.buttonSaveAnswers_Click);
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataMember = "answer";
            this.answerBindingSource.DataSource = this.learnEngDataSet1;
            // 
            // learnEngDataSet1
            // 
            this.learnEngDataSet1.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 418);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(75, 16);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "labelResult";
            this.labelResult.Visible = false;
            // 
            // userTestBindingSource
            // 
            this.userTestBindingSource.DataMember = "userTest";
            this.userTestBindingSource.DataSource = this.learnEngDataSet2;
            // 
            // learnEngDataSet2
            // 
            this.learnEngDataSet2.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTestTableAdapter
            // 
            this.userTestTableAdapter.ClearBeforeFill = true;
            // 
            // FormTestsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSaveAnswers);
            this.Controls.Add(this.dataGridViewAnswers);
            this.Controls.Add(this.textBoxQuestionText);
            this.Name = "FormTestsUser";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.FormTestsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LearnEngDataSet learnEngDataSet;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private LearnEngDataSetTableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.Button buttonSaveAnswers;
        private System.Windows.Forms.BindingSource answerBindingSource;
        private LearnEngDataSet learnEngDataSet1;
        private LearnEngDataSetTableAdapters.answerTableAdapter answerTableAdapter;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.BindingSource userTestBindingSource;
        private LearnEngDataSetTableAdapters.userTestTableAdapter userTestTableAdapter;
        private LearnEngDataSet learnEngDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRightColumn;
    }
}