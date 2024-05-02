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
    public partial class FormResults : Form
    {
        public FormResults()
        {
            InitializeComponent();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.userResults". При необходимости она может быть перемещена или удалена.
            this.userResultsTableAdapter.Fill(this.learnEngDataSet.userResults);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.DataTable1". При необходимости она может быть перемещена или удалена.

        }
    }
}
