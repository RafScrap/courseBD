using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseBD
{
    public partial class FormTestsUser : Form
    {
        DataTable questions;
        String testForm;
        DataTable answers;
        int numRightQuestions;
        int numQuestions;
        int idQuestionGrid;
        int idUser;
        int idTest;

        public FormTestsUser() {
            InitializeComponent();
        }
        public FormTestsUser(int idTest, String testForm, int idUser) {
            InitializeComponent();

            this.idTest = idTest;
            this.idUser = idUser;
            this.testForm = testForm;
            if (testForm == "random") {
                questions = this.questionTableAdapter.GetData(idTest);
            }
            else {
                questions = this.questionTableAdapter.GetDataBy(idTest);
            }
            numQuestions = questions.Rows.Count;
            numRightQuestions = 0;
            idQuestionGrid = 0;
            setQuestion(idQuestionGrid);
            labelResult.Text = "";
        }

        private void setQuestion(int idQuestionGrid) {
            if (questions != null && questions.Rows.Count > 0) {
                DataRow question = questions.Rows[idQuestionGrid];
                int idQuestion = Convert.ToInt32(question["ID"]);
                if (testForm == "dialogue") {
                    textBoxQuestionText.Text = Convert.ToString(question["questionText"]) +
                        Environment.NewLine + Convert.ToString(question["replyWrongText"]);
                }
                else {
                    textBoxQuestionText.Text = Convert.ToString(question["questionText"]);
                }

                answers = this.answerTableAdapter.GetData(idQuestion);
                dataGridViewAnswers.Rows.Clear();
                for (int i = 0; i < answers.Rows.Count; i++) {
                    String answerText = Convert.ToString(answers.Rows[i]["answerText"]);
                    DataGridViewTextBoxCell answerTextCell = new DataGridViewTextBoxCell();
                    answerTextCell.Value = answerText;

                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.Cells.Add(answerTextCell);
                    dataGridViewRow.Cells.Add(new DataGridViewCheckBoxCell());
                    dataGridViewAnswers.Rows.Add(dataGridViewRow);
                }
            }
        }

        private void buttonSaveAnswers_Click(object sender, EventArgs e) {
            bool isRightQuestion = true;
            for (int i = 0; i < answers.Rows.Count; i++) {
                bool isRightAnswerDB = Convert.ToBoolean(answers.Rows[i]["isRight"]);
                DataGridViewCheckBoxCell isRightAnswerCell = dataGridViewAnswers.Rows[i].Cells[1] as DataGridViewCheckBoxCell; ;
                if (Convert.ToBoolean(isRightAnswerCell.Value) != isRightAnswerDB) {
                    isRightQuestion = false;
                }
            }
            if (isRightQuestion) {
                numRightQuestions++;
            }
            if (++idQuestionGrid < questions.Rows.Count) {
                setQuestion(idQuestionGrid);
            }
            else {
                buttonSaveAnswers.Enabled = false;
                labelResult.Text = "Вы ответили правильно на " + numRightQuestions.ToString() + 
                    " вопросов из " + numQuestions.ToString() + ".";
                labelResult.Visible = true;
                this.userTestTableAdapter.Insert(idUser, idTest, DateTime.Now, numRightQuestions,
                    numRightQuestions * 100 / numQuestions);
            }    
        }

        private void FormTestsUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.userTest". При необходимости она может быть перемещена или удалена.
            this.userTestTableAdapter.Fill(this.learnEngDataSet.userTest);

        }
    }

}


