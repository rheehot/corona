namespace corona_api.Models
{
    public interface IQuestionDatabaseSettings
    {
        string QuestionsCollectionName { get; set; }
        string AnswersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

    public class QuestionDatabaseSettings : IQuestionDatabaseSettings
    {
        public string QuestionsCollectionName { get; set; }
        public string AnswersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}