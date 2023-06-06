using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.IO;
using TestForUP01.Model;
using TestForUP01.Utils;

namespace TestForUP01.View
{
    public partial class TestForm : MaterialForm
    {
        private const string questionsPath = "questions.json";

        private List<MaterialRadioButton> _answerRadionButtons;

        private UserModel _user;

        private QuestionModel _currentQuestion;

        private QuestionsModel _questionsModel;

        private int _correctAnswersCount;

        private int _questionIndex;

        public TestForm(UserModel user)
        {
            InitializeComponent();
            FormUtils.InitDefaultDesignToForm(this);

            Load += TestForm_Load;
            _user = user;
            _answerRadionButtons = new List<MaterialRadioButton>();
            _correctAnswersCount = 0;
            _questionIndex = 0;

            _answerRadionButtons.Add(firstAnswerRadioBtn);
            _answerRadionButtons.Add(secondAnswerRadioBtn);
            _answerRadionButtons.Add(thirdAnswerRadioBtn);
            _answerRadionButtons.Add(fourAnswerRadioBtn);
        }

        private void TestForm_Load(object sender, System.EventArgs e)
        {
            var content = File.ReadAllText(questionsPath);
            _questionsModel = QuestionsModel.ParseQuestions(content);
            _currentQuestion = _questionsModel.Questions[_questionIndex];
            UpdateQuestionUI();
        }

        private void UpdateQuestionUI()
        {
            questionTitle.Text = $"{_currentQuestion.Index}. {_currentQuestion.Text}";
            for (var i = 0; i < _answerRadionButtons.Count; i++) 
                _answerRadionButtons[i].Text = _currentQuestion.Answers[i].Text;
        }

        private void NextQuestion()
        {
            _questionIndex++;

            if (_questionIndex == _questionsModel.Questions.Count)
            {
                var resultModel = new ResultModel(_correctAnswersCount, _questionsModel.Questions.Count);
                var resultForm = new ResultForm(resultModel, _questionsModel);
                resultForm.Visible = true;
                Close();
                return;
            }

            _currentQuestion = _questionsModel.Questions[_questionIndex];
        }

        private void acceptAnswerBtn_Click(object sender, System.EventArgs e)
        {
            _currentQuestion.Answers.ForEach(elem =>
            {
                _answerRadionButtons.ForEach(rb =>
                {
                    if (rb.Text == elem.Text && rb.Checked && elem.IsCorrect)
                    {
                        _correctAnswersCount++;
                    }
                });
            });

            NextQuestion();
            UpdateQuestionUI();
        }
    }
}
