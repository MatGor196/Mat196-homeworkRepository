using static BasicApp.EmployeeBase;

namespace BasicApp
{
    public interface IEmployee
    {
        string name { get; }
        string surname { get; }
        string sex { get; }
        int age { get; }

        event ScoreAddedDelegateType ScoreAdded;

        void AddScore(int score);
        void AddScore(float score);
        void AddScore(string score);
        int SumScore();
        Statistics GetStatistics();
    }
}