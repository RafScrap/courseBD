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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResults frmResults = new FormResults();
            frmResults.ShowDialog();
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTests frmTests = new FormTests();
            frmTests.ShowDialog();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourses frmCourses = new FormCourses();
            frmCourses.ShowDialog();
        }

        private void learningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLearning frmLearning = new FormLearning();
            frmLearning.ShowDialog();
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDictionary frmDictionary = new FormDictionary();
            frmDictionary.ShowDialog();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            DataTable dataTable = this.userTableAdapter.GetDataBy1(textBoxLogin.Text, textBoxPassword.Text);
            if (dataTable.Rows.Count > 0) { 
                DataRow row = dataTable.Rows[0];
                System.String userCategory = row["nameUserCategory"] as System.String;
                int idUser = Convert.ToInt32(row["ID"]);
                
                labelNameAndCategoryUser.Text = textBoxLogin.Text + " " + userCategory;
                labelNameAndCategoryUser.Visible = true;
                groupBoxSignIn.Visible = false;
                buttonSignOut.Visible = true;
                
                if (userCategory == "admin") {
                    menuStrip1.Visible = true;
                }
                else if (userCategory == "teacher")
                {
                    dictionaryToolStripMenuItem.Visible = false;
                    menuStrip1.Visible = true;

                }
                else if (userCategory == "student")
                {
                    FormCoursesUser frmCoursesUser = new FormCoursesUser(idUser);
                    frmCoursesUser.ShowDialog();
                }

            }
            else {
                labelIncorrectLoginOrPassword.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creatingMongoDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreatingMongoDB frmCreatingMongoDB = new FormCreatingMongoDB();
            frmCreatingMongoDB.ShowDialog();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            labelNameAndCategoryUser.Visible = false;
            menuStrip1.Visible = false;
            groupBoxSignIn.Visible = true;
            buttonSignOut.Visible = false;
        }


    }
}
