namespace courseBD
{
    partial class FormResults
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnEngDataSet = new courseBD.LearnEngDataSet();
            this.userResultsTableAdapter = new courseBD.LearnEngDataSetTableAdapters.userResultsTableAdapter();
            this.nameUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultProcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameUserDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn,
            this.nameTestDataGridViewTextBoxColumn,
            this.testResultDataGridViewTextBoxColumn,
            this.testResultProcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userResultsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // userResultsBindingSource
            // 
            this.userResultsBindingSource.DataMember = "userResults";
            this.userResultsBindingSource.DataSource = this.learnEngDataSet;
            // 
            // learnEngDataSet
            // 
            this.learnEngDataSet.DataSetName = "LearnEngDataSet";
            this.learnEngDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userResultsTableAdapter
            // 
            this.userResultsTableAdapter.ClearBeforeFill = true;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            this.nameUserDataGridViewTextBoxColumn.DataPropertyName = "nameUser";
            this.nameUserDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.nameUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            this.nameUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "testDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.testDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            this.testDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameTestDataGridViewTextBoxColumn
            // 
            this.nameTestDataGridViewTextBoxColumn.DataPropertyName = "nameTest";
            this.nameTestDataGridViewTextBoxColumn.HeaderText = "Тест";
            this.nameTestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameTestDataGridViewTextBoxColumn.Name = "nameTestDataGridViewTextBoxColumn";
            this.nameTestDataGridViewTextBoxColumn.Width = 125;
            // 
            // testResultDataGridViewTextBoxColumn
            // 
            this.testResultDataGridViewTextBoxColumn.DataPropertyName = "testResult";
            this.testResultDataGridViewTextBoxColumn.HeaderText = "Результаты, баллы";
            this.testResultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testResultDataGridViewTextBoxColumn.Name = "testResultDataGridViewTextBoxColumn";
            this.testResultDataGridViewTextBoxColumn.Width = 125;
            // 
            // testResultProcDataGridViewTextBoxColumn
            // 
            this.testResultProcDataGridViewTextBoxColumn.DataPropertyName = "testResultProc";
            this.testResultProcDataGridViewTextBoxColumn.HeaderText = "Результаты, %";
            this.testResultProcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testResultProcDataGridViewTextBoxColumn.Name = "testResultProcDataGridViewTextBoxColumn";
            this.testResultProcDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormResults";
            this.Text = "Результаты тестирования";
            this.Load += new System.EventHandler(this.FormResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnEngDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LearnEngDataSet learnEngDataSet;
        private System.Windows.Forms.BindingSource userResultsBindingSource;
        private LearnEngDataSetTableAdapters.userResultsTableAdapter userResultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResultProcDataGridViewTextBoxColumn;
    }
}