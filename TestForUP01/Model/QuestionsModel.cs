using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestForUP01.Model
{
    public class QuestionsModel
    {
        public List<QuestionModel> Questions { get; set; }

        public static QuestionsModel ParseQuestions(string content) 
            => JsonConvert.DeserializeObject<QuestionsModel>(content);
    }
}
