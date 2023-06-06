using System.Collections.Generic;

namespace TestForUP01.Model
{
    public class QuestionModel
    {
        public int Index { get; set; }

        public string Text { get; set; }

        public List<AnswerModel> Answers { get; set; }
    }
}
