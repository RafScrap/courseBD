using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace courseBD
{
    public partial class FormTests : Form
    {
        public FormTests()
        {
            idQuestion = 0;
            InitializeComponent();
        }
        int idQuestion;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.testForm". При необходимости она может быть перемещена или удалена.
            this.testFormTableAdapter.Fill(this.learnEngDataSet.testForm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.testType". При необходимости она может быть перемещена или удалена.
            this.testTypeTableAdapter.Fill(this.learnEngDataSet.testType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.topic". При необходимости она может быть перемещена или удалена.
            this.topicTableAdapter.Fill(this.learnEngDataSet.topic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.questionType". При необходимости она может быть перемещена или удалена.
            this.questionTypeTableAdapter.Fill(this.learnEngDataSet.questionType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.learnEngDataSet.test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet4.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.learnEngDataSet4.user);

            int idTest = Convert.ToInt32(comboBoxChooseQuestion.SelectedValue);
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);
            selectedIndex();

        }
        void selectedIndex() {
            comboBoxAddIDCourse.Enabled = false;
            comboBoxAddIDTopic.Enabled = false;
            DataRowView drv = comboBoxAddIDTestType.SelectedItem as DataRowView;
            System.String testType = Convert.ToString(drv.Row["testType"]);
            if (testType == "course") {
                comboBoxAddIDCourse.Enabled = true;
            }
            else if (testType == "topic") {
                comboBoxAddIDTopic.Enabled = true;
            }
        }

        private void comboBoxAddIDTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex();
        }

        private void buttonAddTest_Click(object sender, EventArgs e) {
            int? idTopic = null, idCourse = null;
            DataRowView drv = comboBoxAddIDTestType.SelectedItem as DataRowView;
            System.String testType = Convert.ToString(drv.Row["testType"]);
            if (testType == "course") {
                idCourse = Convert.ToInt32(comboBoxAddIDCourse.SelectedValue);
            }
            else if (testType == "topic") {
                idTopic = Convert.ToInt32(comboBoxAddIDTopic.SelectedValue);
            }
            this.testTableAdapter.Insert(textBoxAddTest.Text,
                idTopic, idCourse,
                Convert.ToInt32(comboBoxAddIDTestType.SelectedValue), 
                Convert.ToInt32(comboBoxAddIDTestForm.SelectedValue));
            this.testTableAdapter.Fill(this.learnEngDataSet.test);
        }

        private void buttonChangeTest_Click(object sender, EventArgs e) {
            DataRowView drv = (testBindingSource.Current as DataRowView);
            int? idTopic = null, idCourse = null;
            if (!drv["IDCourse"].Equals(System.DBNull.Value)) {
                idCourse = Convert.ToInt32(drv["IDCourse"]);
            }
            if (!drv["IDTopic"].Equals(System.DBNull.Value)) {
                idTopic = Convert.ToInt32(drv["IDTopic"]);
            }
            this.testTableAdapter.Update(textBoxChangeTest.Text,
                idTopic, idCourse,
                Convert.ToInt32(drv["IDTestType"]),
                Convert.ToInt32(drv["IDTestForm"]),
                Convert.ToInt32(drv["ID"]));
            this.testTableAdapter.Fill(this.learnEngDataSet.test);
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e) {
            DataRowView drv = (testBindingSource.Current as DataRowView);
            this.testTableAdapter.Delete(Convert.ToInt32(drv["ID"]));
            this.testTableAdapter.Fill(this.learnEngDataSet.test);
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e) {
            DataRowView drv = (testBindingSource1.Current as DataRowView);
            int idTest = Convert.ToInt32(drv["ID"]);
            this.questionTableAdapter.Insert(idTest, textBoxAddQuestion.Text,
                textBoxAddReplyRight.Text, textBoxAddReplyWrong.Text,
                Convert.ToInt32(comboBoxAddQuestionType.SelectedValue),
                Convert.ToInt32(textBoxAddNumQuestionInTest.Text));
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);

        }

        private void buttonChangeQuestion_Click(object sender, EventArgs e) {
            DataRowView drv = (testBindingSource1.Current as DataRowView);
            int idTest = Convert.ToInt32(drv["ID"]);
            DataRowView drvQuestion = (questionBindingSource.Current as DataRowView);
            int idQuestionCurrent = Convert.ToInt32(drvQuestion["ID"]);
            int idQuestionTypeCurrent = Convert.ToInt32(drvQuestion["IDQuestionType"]);

            this.questionTableAdapter.Update(idTest, textBoxChangeQuestion.Text,
                textBoxChangeReplyRight.Text, textBoxChangeReplyWrong.Text,
                idQuestionTypeCurrent, Convert.ToInt32(textBoxChangeNumberQuestion.Text),
                idQuestionCurrent);
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e) {
            DataRowView drv = (testBindingSource1.Current as DataRowView);
            int idTest = Convert.ToInt32(drv["ID"]);
            DataRowView drvQuestion = (questionBindingSource.Current as DataRowView);
            int idQuestionCurrent = Convert.ToInt32(drvQuestion["ID"]);

            this.questionTableAdapter.Delete(idQuestionCurrent);
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);
        }

        private void comboBoxChooseQuestion_SelectedIndexChanged(object sender, EventArgs e) {
            int idTest = Convert.ToInt32(comboBoxChooseQuestion.SelectedValue);
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);

        }
        private void buttonRefreshQuestion_Click(object sender, EventArgs e) {
            int idTest = Convert.ToInt32(comboBoxChooseQuestion.SelectedValue);
            this.questionTableAdapter.Fill(this.learnEngDataSet2.question, idTest);
        }

        private void dataGridViewQuestions_SelectionChanged(object sender, EventArgs e) {
            DataRowView drv = (questionBindingSource.Current as DataRowView);
            if (drv != null) {
                idQuestion = (int)drv.Row["ID"];
            }
            else {
                idQuestion = 0;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet1.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.learnEngDataSet1.answer, idQuestion);
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e) {
            this.answerTableAdapter.Insert(idQuestion, textBoxAddAnswerText.Text,
                Convert.ToInt32(checkBoxAddIsRight.Checked));
            this.answerTableAdapter.Fill(this.learnEngDataSet1.answer, idQuestion);
        }

        private void buttonChangeAnswer_Click(object sender, EventArgs e) {
            DataRowView drv = (answerBindingSource.Current as DataRowView);
            this.answerTableAdapter.Update(idQuestion, textBoxChangeAnswerText.Text,
                Convert.ToInt32(checkBoxChangeIsRight.Checked),
                Convert.ToInt32(drv["ID"]));
            this.answerTableAdapter.Fill(this.learnEngDataSet1.answer, idQuestion);
        }

        private void buttonDeleteAnswer_Click(object sender, EventArgs e) {
            DataRowView drv = (answerBindingSource.Current as DataRowView);
            this.answerTableAdapter.Delete(Convert.ToInt32(drv["ID"]));
            this.answerTableAdapter.Fill(this.learnEngDataSet1.answer, idQuestion);
        }
    }
}
