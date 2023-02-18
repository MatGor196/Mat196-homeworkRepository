namespace BasicApp
{
    public class Statistics
    {
        public int MinScore { get; private set; }
        public int MaxScore { get; private set; }
        public float AverageScore 
        {
            get
            {
                if(this.Count != 0)
                {
                    return this.SumScore / this.Count;
                }
                else
                {
                    return 0;
                }
            }
            private set { }
        }
        public char AverageScoreLetter
        {
            get
            {
                switch (this.AverageScore)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
            private set { }
        }
        public int SumScore { get; private set; }
        public int Count { get; private set; }
        public Statistics()
        {
            this.MinScore = int.MaxValue;
            this.MaxScore = int.MinValue;
            this.Count = 0;
            this.SumScore = 0;
        }

        public void AddScore(int grade)
        {
            this.Count++;
            this.SumScore += grade;
            this.MinScore = Math.Min(this.MinScore,grade);
            this.MaxScore = Math.Max(this.MaxScore, grade);
        }
    }
}
