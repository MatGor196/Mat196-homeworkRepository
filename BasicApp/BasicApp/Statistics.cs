namespace BasicApp
{
    public class Statistics
    {
        public float MinScore { get; set; }
        public float MaxScore { get; set; }
        public float AverageScore { get; set; }
        public char AverageScoreLetter { get; set; }
        public Statistics()
        {
            this.MinScore = float.MaxValue;
            this.MaxScore = float.MinValue;
            this.AverageScore = 0;
            this.AverageScoreLetter = 'E';
        }
    }
}
