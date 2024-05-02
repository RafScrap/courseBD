using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace courseBD
{
    public partial class FormCreatingMongoDB : Form
    {
        public FormCreatingMongoDB()
        {
            InitializeComponent();
        }

        private void FormCreatingMongoDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.learnEngDataSet.test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "learnEngDataSet.course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.learnEngDataSet.course);
        }

        private void buttonFillMongoDB_Click(object sender, EventArgs e) {
            client = new MongoClient(textBoxPathDB.Text);
            db = client.GetDatabase("todo-app");

            db.DropCollection("topics");
            db.CreateCollection("topics");
            var topics = db.GetCollection<Topic>("topics");

            db.DropCollection("simpletheories");
            db.CreateCollection("simpletheories");
            var simpleTheories = db.GetCollection<TopicTheories>("simpletheories");

            db.DropCollection("simplequizzes");
            db.CreateCollection("simplequizzes");
            var simpleQuizzes = db.GetCollection<BsonDocument>("simplequizzes");

            DataTable tableCourseTopic = this.courseTopicFullTableAdapter.GetData(idCourse);

            for (int i = 0; i < tableCourseTopic.Rows.Count; i++) {
                DataRow rowCourseTopic = tableCourseTopic.Rows[i];
                int idTopic = (int)rowCourseTopic["IDTopic"];

                Topic elemTopic = new Topic {
                    topic = rowCourseTopic["nameTopic"].ToString(),
                    text = rowCourseTopic["textTopic"].ToString(),
                    id = idTopic.ToString()
                };
                topics.InsertOne(elemTopic);

                TopicTheories topicTheories = new TopicTheories {
                    topicId = idTopic.ToString(),
                    picture = rowCourseTopic["pictureFile"].ToString(),
                };
                DataTable dataPart = this.partTableAdapter.GetData(idTopic);
                for (int k = 0; k < dataPart.Rows.Count; k++) {
                    DataRow rowPart = dataPart.Rows[k];

                    int idPart = (int)rowPart["ID"];
                    BsonDocument part = new BsonDocument {
                            {"header",  rowPart["headerPart"].ToString()},
                            { "text" , rowPart["textPart"].ToString() },
                            { "examples", examples(idPart) },
                            { "picture", rowPart["pictureFile"].ToString()}
                        };
                    topicTheories.theories.Add(part);
                }
                simpleTheories.InsertOne(topicTheories);

                BsonDocument quiz = new BsonDocument {
                    {"topic",  idTopic.ToString()},
                    {"dialogues" , dialogues(idTopic) }
                };
                simpleQuizzes.InsertOne(quiz);
            }
        }

        MongoClient client;
        IMongoDatabase db;
        int idCourse = 1;
        private void comboBoxChooseCourse_SelectedIndexChanged(object sender, EventArgs e) {
            idCourse = Convert.ToInt32(comboBoxChooseCourse.SelectedValue);
        }

        BsonArray examples(int idPart) {
            BsonArray examples = new BsonArray();
            DataTable dataExample = this.exampleTableAdapter.GetData(idPart);
            for (int j = 0; j < dataExample.Rows.Count; j++) {
                DataRow rowExample = dataExample.Rows[j];
                BsonDocument example = new BsonDocument {
                        {"example",  rowExample["exampleText"].ToString()},
                        {"note",  rowExample["noteText"].ToString()},
                        { "translation" , rowExample["translationText"].ToString() }
                    };
                examples.Add(example);
            }
            return examples;
        }

        BsonArray dialogues(int IDTopic) {
            BsonArray dialogues = new BsonArray();
            DataTable dataTest = this.testTableAdapter.GetDataBy(IDTopic);
            for (int i = 0; i < dataTest.Rows.Count; i++) {
                DataRow dataTestRow = dataTest.Rows[i];
                int idTest = (int)dataTestRow["ID"];
                BsonDocument dialogue = new BsonDocument
                { { "phrases", phrases(idTest) } };
                dialogues.Add(dialogue);
            }
            return dialogues;
        }

        BsonArray phrases(int IDTest) {
            BsonArray phrases = new BsonArray();
            DataTable dataQuestion = this.questionTableAdapter.GetDataBy(IDTest);
            for (int i = 0; i < dataQuestion.Rows.Count; i++) {
                DataRow dataQuestionRow = dataQuestion.Rows[i];

                BsonDocument phrase = new BsonDocument {
                    { "question", dataQuestionRow["questionText"].ToString() },
                    { "reply", dataQuestionRow["replyWrongText"].ToString() }
                };
                int IDQuestion = (int)dataQuestionRow["ID"];
                BsonArray answers = new BsonArray();
                DataTable dataAnswers = this.answerTableAdapter.GetData(IDQuestion);
                for (int k = 0; k < dataAnswers.Rows.Count; k++) {
                    DataRow dataAnswersRow = dataAnswers.Rows[k];
                    String answer = dataAnswersRow["answerText"].ToString();
                    answers.Add(dataAnswersRow["answerText"].ToString());
                    if (Convert.ToBoolean(dataAnswersRow["isRight"])){
                        phrase.Add(new BsonElement("answerIndex", k));
                    }
                }
                phrase.Add(new BsonElement("answers", answers));
                phrases.Add(phrase);
            }
            return phrases;
        }
    }
}


class TopicTheories
{
    public ObjectId Id { get; set; }
    public string topicId { get; set; } = "";
    public string picture { get; set; } = "";
    public BsonArray theories { get; set; } = new BsonArray { };
}

class Topic {
    public ObjectId Id { get; set; }
    public string topic { get; set; } = "";
    public string text { get; set; } = "";
    public string id { get; set; } = "";
}
