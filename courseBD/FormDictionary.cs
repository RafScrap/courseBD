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
    public partial class FormDictionary : Form
    {
        public FormDictionary()
        {
            InitializeComponent();
        }

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.userCategory". При необходимости она может быть перемещена или удалена.
            this.userCategoryTableAdapter.Fill(this.learnEngDataSet.userCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.FillBy(this.learnEngDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.userCategory". При необходимости она может быть перемещена или удалена.
            this.userCategoryTableAdapter.Fill(this.learnEngDataSet.userCategory);
        }

        private void buttonAddUser_Click(object sender, EventArgs e) {
            this.userTableAdapter.Insert(textBoxAddUser.Text,
                Convert.ToInt32(comboBoxAddUserCategory.SelectedValue), 
                textBoxlAddPassword.Text);
            this.userTableAdapter.FillBy(this.learnEngDataSet.user);
        }

        private void buttonChangeUser_Click(object sender, EventArgs e) {
            DataRowView drv = (userBindingSource.Current as DataRowView);
            int idUserCurrent = Convert.ToInt32(drv["ID"]);
            int idUserCategoryCurrent = Convert.ToInt32(drv["IDUserCategory"]);
            this.userTableAdapter.Update(textBoxChangeUser.Text,
                idUserCategoryCurrent, textBoxChangePassword.Text, idUserCurrent);
            this.userTableAdapter.FillBy(this.learnEngDataSet.user);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e) {
            DataRowView drv = (userBindingSource.Current as DataRowView);
            int idUserCurrent = Convert.ToInt32(drv["ID"]);
            this.userTableAdapter.Delete(idUserCurrent);
            this.userTableAdapter.Fill(this.learnEngDataSet.user);
        }
    }
}
