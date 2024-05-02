using System;
using System.Data;
using System.Windows.Forms;

namespace courseBD
{
    public partial class FormLearning : Form
    {
        public FormLearning()
        {
            idPart = 0;
            InitializeComponent();
        }

        int idPart;
        private void FormLearning_Load(object sender, EventArgs e)
        {
            this.topicTableAdapter.Fill(this.learnEngDataSet.topic);

            int idTopic = (int)comboBoxChooseTopic.SelectedValue;
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
        }

        private void buttonAddTopic_Click(object sender, EventArgs e)
        {
            this.topicTableAdapter.Insert(textBoxAddNameTopic.Text,
                textBoxAddTextTopic.Text, textBoxAddPictureFile.Text);
            this.topicTableAdapter.Fill(this.learnEngDataSet.topic);

        }

        private void buttonChangeTopic_Click(object sender, EventArgs e)
        {
            DataRowView drv = (topicBindingSource.Current as DataRowView);
            int idTopicCurrent = Convert.ToInt32(drv["ID"]);
            this.topicTableAdapter.Update(textBoxNameTopic.Text,
    textBoxTextTopic.Text, textBoxChangePictureFile.Text, idTopicCurrent);
            this.topicTableAdapter.Fill(this.learnEngDataSet.topic);
        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e)
        {
            DataRowView drv = (topicBindingSource.Current as DataRowView);
            int idTopicCurrent = Convert.ToInt32(drv["ID"]);
            this.topicTableAdapter.Delete(Convert.ToInt32(idTopicCurrent));
            this.topicTableAdapter.Fill(this.learnEngDataSet.topic);
        }

        private void comboBoxChooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
        }

        private void buttonRefreshTopic_Click(object sender, EventArgs e)
        {
            int idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);
        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            int idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            this.partTableAdapter.Insert(idTopic, textBoxAddHeaderPart.Text,
                textBoxAddTextPart.Text, Convert.ToInt32(textBoxAddNumPartInTopic.Text),
                textBoxAddPictureFilePart.Text);
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);

        }

        private void buttonChangePart_Click(object sender, EventArgs e)
        {
            int idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            DataRowView drv = (partBindingSource.Current as DataRowView);
            int idPartCurrent = Convert.ToInt32(drv["ID"]);
            this.partTableAdapter.Update(idTopic, textBoxChangeHeaderPart.Text,
                textBoxChangeTextPart.Text,
                Convert.ToInt32(textBoxChangeNumPartInTopic.Text),
                textBoxChangePictureFilePart.Text,
                Convert.ToInt32(idPartCurrent));
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);

        }

        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            int idTopic = Convert.ToInt32(comboBoxChooseTopic.SelectedValue);
            DataRowView drv = (partBindingSource.Current as DataRowView);
            int idPartCurrent = Convert.ToInt32(drv["ID"]);
            this.partTableAdapter.Delete(Convert.ToInt32(idPartCurrent));
            this.partTableAdapter.Fill(this.learnEngDataSet1.part, idTopic);

        }

        private void buttonAddExample_Click(object sender, EventArgs e)
        {
            this.exampleTableAdapter.Insert(idPart, textBoxAddExampleText.Text,
                    textBoxAddNoteText.Text, textBoxAddTranslationText.Text);
            this.exampleTableAdapter.Fill(this.learnEngDataSet2.example, idPart);
        }

        private void buttonChangeExample_Click(object sender, EventArgs e)
        {
            DataRowView drv = (exampleBindingSource.Current as DataRowView);
            int idExampleCurrent = Convert.ToInt32(drv["ID"]);
            this.exampleTableAdapter.Update(idPart, textBoxChangeExampleText.Text,
         textBoxChangeNoteText.Text, textBoxChangeTranslationText.Text, 
         idExampleCurrent);
            this.exampleTableAdapter.Fill(this.learnEngDataSet2.example, idPart);
        }

        private void buttonDeleteExample_Click(object sender, EventArgs e)
        {
            DataRowView drv = (exampleBindingSource.Current as DataRowView);
            int idExampleCurrent = Convert.ToInt32(drv["ID"]);
            this.exampleTableAdapter.Delete(idExampleCurrent);
            this.exampleTableAdapter.Fill(this.learnEngDataSet2.example, idPart);
        }

        private void dataGridViewTopic_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView drv = (partBindingSource.Current as DataRowView);
            if (drv != null) {
                idPart = (int)drv.Row["ID"];
            }
            else {
                idPart = 0;
            }
            this.exampleTableAdapter.Fill(this.learnEngDataSet2.example, idPart);
        }
    }
}
