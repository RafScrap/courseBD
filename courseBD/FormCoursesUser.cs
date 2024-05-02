using System;
using System.Data;
using System.Windows.Forms;

namespace courseBD
{
    public partial class FormCoursesUser : Form
    {
        int idUser = 0;
        int idCourse = 0;
        int idTopic = 0;
        int idPart = 0;
        int idTest = 0;
        String strRes;

        public FormCoursesUser() {
            InitializeComponent();
        }
        public FormCoursesUser(int idUser) {
            InitializeComponent();
            this.idUser = idUser;
        }
        private void FormCoursesUser_Load(object sender, EventArgs e) {

            this.courseUserFullTableAdapter.Fill(this.learnEngDataSet.courseUserFull, idUser);

            idCourse = Convert.ToInt32(comboBoxChooseCourse.SelectedValue);
            this.courseTopicFullTableAdapter.Fill(this.learnEngDataSet0.courseTopicFull, idCourse);
            idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
            selectionPartChanged();

            //radioButtonTestTypeUnlinked.Checked = true;

        }

        private void comboBoxChooseCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCourse = Convert.ToInt32(comboBoxChooseCourse.SelectedValue);
            this.courseTopicFullTableAdapter.Fill(this.learnEngDataSet0.courseTopicFull, idCourse);

            if (radioButtonTestTypeCourse.Checked) 
            {
                dataGridViewChooseTests.DataSource = testBindingSource;
                this.testTableAdapter.FillBy1(this.learnEngDataSet4.test, idCourse);
            }
        }
        private void comboBoxChooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
            
            if (radioButtonTestTypeTopic.Checked) {
                dataGridViewChooseTests.DataSource = testBindingSource;
                this.testTableAdapter.FillBy(this.learnEngDataSet4.test, idTopic);
            }

        }
        private void selectionPartChanged() {
            DataRowView drv = (partBindingSource.Current as DataRowView);
            if (drv != null) {
                idPart = (int)drv.Row["ID"];
            }
            else {
                idPart = 0;
            }
            
            this.getExamples2TableAdapter.GetData(idPart, ref strRes);
            if (strRes == null) {
                strRes = "";   
            }
            textBoxExamples.Text = strRes.Replace("\\r\\n", "\r\n");
        }

        private void dataGridViewChoosePart_SelectionChanged(object sender, EventArgs e) {
            selectionPartChanged();
        }

        private void buttonRefreshTopic_Click(object sender, EventArgs e) {
            idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
        }

        private void radioButtonTestTypeCourse_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonTestTypeCourse.Checked) {

                dataGridViewChooseTests.DataSource = testBindingSource;
                idCourse = Convert.ToInt32(comboBoxChooseCourse.SelectedValue);
                this.testTableAdapter.FillBy1(this.learnEngDataSet4.test, idCourse);
                if (dataGridViewChooseTests.Columns.Contains("ID"))
                {
                    dataGridViewChooseTests.Columns.Remove("ID");
                    dataGridViewChooseTests.Columns.Remove("IDTopic");
                    dataGridViewChooseTests.Columns.Remove("IDCourse");
                    dataGridViewChooseTests.Columns.Remove("IDTestType");
                    dataGridViewChooseTests.Columns.Remove("IDTestForm");

                    renameColumn("nameTest", "Название теста");
                    renameColumn("testForm", "Форма теста");
                    renameColumn("testType", "Тип теста");
                    renameColumn("nameTopic", "Тема");
                    renameColumn("nameCourse", "Курс");
                }
            }
        }

        private void radioButtonTestTypeTopic_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonTestTypeTopic.Checked) {

                dataGridViewChooseTests.DataSource = testBindingSource;
                idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
                this.testTableAdapter.FillBy(this.learnEngDataSet4.test, idTopic);
                if (dataGridViewChooseTests.Columns.Contains("ID")) {
                    dataGridViewChooseTests.Columns.Remove("ID");
                    dataGridViewChooseTests.Columns.Remove("IDTopic");
                    dataGridViewChooseTests.Columns.Remove("IDCourse");
                    dataGridViewChooseTests.Columns.Remove("IDTestType");
                    dataGridViewChooseTests.Columns.Remove("IDTestForm");

                    renameColumn("nameTest", "Название теста");
                    renameColumn("testForm", "Форма теста");
                    renameColumn("testType", "Тип теста");
                    renameColumn("nameTopic", "Тема");
                    renameColumn("nameCourse", "Курс");
                }
            }
        }

        private void radioButtonTestTypeUnlinked_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonTestTypeUnlinked.Checked) {

                dataGridViewChooseTests.DataSource = userUnlinkedTestBindingSource;
                this.userUnlinkedTestTableAdapter.Fill(this.learnEngDataSet3.userUnlinkedTest, idUser);
                dataGridViewChooseTests.Columns.Remove("ID");
                dataGridViewChooseTests.Columns.Remove("IDUser");
                dataGridViewChooseTests.Columns.Remove("IDTest");
                dataGridViewChooseTests.Columns.Remove("IDTestType");
                dataGridViewChooseTests.Columns.Remove("IDTestForm");
                renameColumn("nameTest", "Название теста");
                renameColumn("testForm", "Форма теста");
                renameColumn("testType", "Тип теста");
            }
        }

        private void dataGridViewChooseTests_SelectionChanged(object sender, EventArgs e) {
            selectionTestChanged();
        }

        private void selectionTestChanged()
        {
            DataRowView drv = (testBindingSource.Current as DataRowView);
            if (drv != null) {
                idTest = (int)drv.Row["ID"];
            }
            else {
                idTest = 0;
            }
        }

        private void buttonStartTest_Click(object sender, EventArgs e) {
            if (idTest != 0) {
                DataRowView drv = (testBindingSource.Current as DataRowView);
                FormTestsUser formTestsUser = new FormTestsUser(idTest, Convert.ToString(drv.Row["testForm"]), idUser);
                formTestsUser.ShowDialog();
            }
        }

        void renameColumn(String oldName, String newName) {
            DataGridViewColumn column = dataGridViewChooseTests.Columns[oldName];
            column.HeaderText = newName;
        }
    }
}
