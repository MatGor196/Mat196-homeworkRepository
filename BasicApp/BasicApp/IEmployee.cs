namespace BasicApp
{
    public interface IEmployee
    {
        public string name { get; }
        public string surname { get; }
        public string sex { get; }
        public int age { get; }
        public void AddScore(int score);
        public void AddScore(float score);
        public void AddScore(string score);
        public int SumScore();
        public Statistics GetStatistics();
    }
}