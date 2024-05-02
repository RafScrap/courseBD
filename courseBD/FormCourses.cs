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
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {

            //Данные для таблицы на первой вкладке
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
            //Данные для comboBox на первой вкладке
            this.courseLevelTableAdapter.Fill(this.learnEngDataSet.courseLevel);
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet1.courseUser". При необходимости она может быть перемещена или удалена.
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForUser.SelectedValue);
            this.courseUserTableAdapter.Fill(this.learnEngDataSet1.courseUser, idCourse);  
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.FillBy(this.learnEngDataSet.user);

            idCourse = Convert.ToInt32(comboBoxChooseCourseForTopic.SelectedValue);
            this.courseTopicTableAdapter.Fill(this.learnEngDataSet2.courseTopic, idCourse);

            // Данные для comboBox на третьей вкладке
            this.topicTableAdapter.FillBy(this.learnEngDataSet.topic);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            this.courseTableAdapter.Insert(textBoxAddNameCourse.Text, textBoxAddTextCourse.Text,
                (int)comboBoxAddCourseLevel.SelectedValue);
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
        }

        private void buttonChangeCourse_Click(object sender, EventArgs e) {
            DataRowView drv = (courseBindingSource.Current as DataRowView);
            int idCourseCurrent = Convert.ToInt32(drv["ID"]);
            int idCourseLevelCurrent = Convert.ToInt32(drv["IDCourseLevel"]);
            this.courseTableAdapter.Update(textBoxChangeNameCourse.Text, 
                textBoxChangeTextCourse.Text, idCourseLevelCurrent, idCourseCurrent);
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (courseBindingSource.Current as DataRowView);
            int idCourseCurrent = Convert.ToInt32(drv["ID"]);
            this.courseTableAdapter.Delete(idCourseCurrent);
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
        }

        private void comboBoxChooseCourseForUser_SelectedIndexChanged(object sender, EventArgs e) {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForUser.SelectedValue);
            this.courseUserTableAdapter.Fill(this.learnEngDataSet1.courseUser, idCourse);
        }

        private void buttonRefreshUsers_Click(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForUser.SelectedValue);
            this.courseUserTableAdapter.Fill(this.learnEngDataSet1.courseUser, idCourse);

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForUser.SelectedValue);
            this.courseUserTableAdapter.Insert((int)comboBoxAddUser.SelectedValue, idCourse);
            this.courseUserTableAdapter.Fill(this.learnEngDataSet1.courseUser, idCourse);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForUser.SelectedValue);
            DataRowView drv = (courseUserBindingSource.Current as DataRowView);
            int idCourseUserCurrent = Convert.ToInt32(drv["ID"]);
            this.courseUserTableAdapter.Delete(idCourseUserCurrent);
            this.courseUserTableAdapter.Fill(this.learnEngDataSet1.courseUser, idCourse);

        }

        private void comboBoxChooseCourseForTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForTopic.SelectedValue);
            this.courseTopicTableAdapter.Fill(this.learnEngDataSet2.courseTopic, idCourse);
        }

        private void buttonRefreshTopic_Click(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForTopic.SelectedValue);
            this.courseTopicTableAdapter.Fill(this.learnEngDataSet2.courseTopic, idCourse);
        }

        private void buttonAddTopic_Click(object sender, EventArgs e)
        {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForTopic.SelectedValue);
            int idTopic = Convert.ToInt32(comboBoxAddTopic.SelectedValue);
            int numTopicInCourse = Convert.ToInt32(textBoxNumTopicInCourse.Text);
            this.courseTopicTableAdapter.Insert(idCourse, idTopic, numTopicInCourse);
            this.courseTopicTableAdapter.Fill(this.learnEngDataSet2.courseTopic, idCourse);

        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e) {
            int idCourse = Convert.ToInt32(comboBoxChooseCourseForTopic.SelectedValue);
            DataRowView drv = (courseTopicBindingSource.Current as DataRowView);
            int idCourseTopicCurrent = Convert.ToInt32(drv["ID"]);

            this.courseTopicTableAdapter.Delete(idCourseTopicCurrent);
            this.courseTopicTableAdapter.Fill(this.learnEngDataSet2.courseTopic, idCourse);
        }
    }
}
