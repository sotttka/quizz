using MaterialSkin.Controls;
using System.Windows.Forms;
using TestForUP01.Model;
using TestForUP01.Utils;

namespace TestForUP01.View
{
    public partial class ResultForm : MaterialForm
    {
        private ResultModel _resultModel;

        private QuestionsModel _questionsModel;

        public ResultForm(ResultModel resultModel, QuestionsModel questionsModel)
        {
            InitializeComponent();
            FormUtils.InitDefaultDesignToForm(this);
            Load += ResultForm_Load;

            _resultModel = resultModel;
            _questionsModel = questionsModel;
        }

        private void ResultForm_Load(object sender, System.EventArgs e)
        {
            ShowEstimate();
            ShowCorrectAnswers();
        }

        private void ShowEstimate()
        {
            title.Text = $"Итого: правильных ответов - {_resultModel.CorrectAnswersCount} из {_resultModel.AllQuestionsCount}";
            var estimationModel = new EstimationModel((_resultModel.CorrectAnswersCount / _resultModel.AllQuestionsCount) * 5);

            estimation.Text = $"Ваша оценка: {estimationModel}";
        }

        private void ShowCorrectAnswers()
        {
            _questionsModel.Questions.ForEach(q =>
            {
                q.Answers.ForEach(a =>
                {
                    if (a.IsCorrect)
                    {
                        correctAnswers.Text += $"{q.Index}. {a.Text}\n";
                    }
                });
            });
        }

        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}
