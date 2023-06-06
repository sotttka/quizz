namespace TestForUP01.Model
{
    public class ResultModel
    {
        public int CorrectAnswersCount { get; private set; }

        public int AllQuestionsCount { get; set; }

        public ResultModel(int correctAnswersCount, int allQuestionsCount)
        {
            CorrectAnswersCount = correctAnswersCount;
            AllQuestionsCount = allQuestionsCount;
        }
    }
}
